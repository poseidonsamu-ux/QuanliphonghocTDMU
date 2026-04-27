using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public class TraCuuDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayToaNha() => kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");
        public DataTable LayGiangVien() => kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");

        public DataTable LayPhongHocTheoToaNha(string maToaNha)
        {
            string sql = (maToaNha == "ALL")
                ? "SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc"
                : string.Format("SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc WHERE MaToaNha = '{0}'", maToaNha);
            return kn.ExecuteQuery(sql);
        }

        // CẬP NHẬT: Lấy thêm tên Giảng viên đã đặt
        public DataTable LayPhongDaBiDat(string ngay, string ca)
        {
            string sql = string.Format(@"
                SELECT l.MaPhong, g.HoTen 
                FROM LichDatPhong l 
                JOIN GiangVien g ON l.MaGV = g.MaGV 
                WHERE l.NgayDat = '{0}' AND l.CaHoc = {1} AND l.TrangThaiDuyet != N'Từ chối'", ngay, ca);
            return kn.ExecuteQuery(sql);
        }

        public DataTable LayThietBiTheoPhong(string maPhong)
        {
            string sql = string.Format("SELECT tb.TenTB, tbp.SoLuong FROM TrangBiPhong tbp JOIN ThietBi tb ON tbp.MaTB = tb.MaTB WHERE tbp.MaPhong = '{0}'", maPhong);
            return kn.ExecuteQuery(sql);
        }

        public bool DatPhong(LichDatPhongDTO ld)
        {
            string sql = string.Format("INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, N'{6}', N'{7}')",
                ld.MaPhong, ld.MaGV, ld.NgayDat.ToString("yyyy-MM-dd"), ld.CaHoc, ld.TietBatDau, ld.TietKetThuc, ld.MucDich, ld.TrangThaiDuyet);
            return kn.ExecuteNonQuery(sql);
        }

        // THÊM MỚI: Hàm xóa lịch đặt phòng
        public bool XoaDatPhong(string maPhong, string ngay, string ca)
        {
            string sql = string.Format("DELETE FROM LichDatPhong WHERE MaPhong = '{0}' AND NgayDat = '{1}' AND CaHoc = {2}", maPhong, ngay, ca);
            return kn.ExecuteNonQuery(sql);
        }
    }
}