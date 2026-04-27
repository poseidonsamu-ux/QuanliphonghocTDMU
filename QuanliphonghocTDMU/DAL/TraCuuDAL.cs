using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TraCuuDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayToaNha() => kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");
        public DataTable LayGiangVien() => kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");

        public DataTable LayPhongHocTheoToaNha(string maToaNha)
        {
            // Lấy hết phòng để test cho hiện 
            string sql = (maToaNha == "ALL")
                ? "SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc"
                : string.Format("SELECT MaPhong, TenPhong, LoaiPhong, SucChua FROM PhongHoc WHERE MaToaNha = '{0}'", maToaNha);
            return kn.ExecuteQuery(sql);
        }

        public DataTable LayPhongDaBiDat(string ngay, string ca)
        {
            string sql = string.Format("SELECT MaPhong FROM LichDatPhong WHERE NgayDat = '{0}' AND CaHoc = {1} AND TrangThaiDuyet != N'Từ chối'", ngay, ca);
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
    }
}