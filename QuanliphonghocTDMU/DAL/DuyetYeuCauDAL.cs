using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class DuyetYeuCauDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachChoDuyet()
        {
            string sql = @"
                SELECT 
                    l.MaDatPhong AS [Mã Đặt], 
                    p.TenPhong AS [Phòng], 
                    g.HoTen AS [Giảng Viên], 
                    l.NgayDat AS [Ngày Đặt], 
                    l.CaHoc AS [Ca], 
                    l.MucDich AS [Mục Đích],
                    l.TrangThaiDuyet AS [Trạng Thái]
                FROM LichDatPhong l
                JOIN PhongHoc p ON l.MaPhong = p.MaPhong
                JOIN GiangVien g ON l.MaGV = g.MaGV
                WHERE l.TrangThaiDuyet = N'Chờ duyệt'
                ORDER BY l.NgayDat ASC";
            return kn.ExecuteQuery(sql);
        }

        public bool CapNhatTrangThai(string maDat, string trangThai)
        {
            // MaDatPhong là số nên không cần dấu nháy đơn trong SQL
            string sql = string.Format("UPDATE LichDatPhong SET TrangThaiDuyet = N'{0}' WHERE MaDatPhong = {1}", trangThai, maDat);
            return kn.ExecuteNonQuery(sql);
        }
    }
}