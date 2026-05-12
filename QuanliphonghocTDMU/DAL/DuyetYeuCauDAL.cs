using System;
using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class DuyetYeuCauDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        // Lấy danh sách yêu cầu chờ duyệt
        public DataTable GetYeuCauMuonPhong(string maGV, string role)
        {
            string sql = @"
                SELECT ld.MaDatPhong AS [Mã YC], ld.NgayDat AS [Ngày], ld.CaHoc AS [Ca], 
                       ld.MaPhong AS [Phòng], gv.HoTen AS [Giảng viên], ld.MucDich AS [Mục đích], ld.TrangThaiDuyet AS [Trạng thái]
                FROM LichDatPhong ld JOIN GiangVien gv ON ld.MaGV = gv.MaGV ";

            if (role == "Admin") sql += " WHERE ld.TrangThaiDuyet = N'Chờ duyệt'";
            else sql += $" WHERE ld.MaGV = '{maGV}'";

            return kn.ExecuteQuery(sql + " ORDER BY ld.NgayDat DESC");
        }

        // Cập nhật trạng thái
        public bool CapNhatTrangThaiYeuCau(int maDatPhong, string trangThai)
        {
            string sql = $"UPDATE LichDatPhong SET TrangThaiDuyet = N'{trangThai}' WHERE MaDatPhong = {maDatPhong}";
            return kn.ExecuteNonQuery(sql);
        }

        // QUAN TRỌNG: Lấy Email mới nhất của Giảng viên từ bảng GiangVien
        public string GetEmailGiangVienByMaDat(int maDatPhong)
        {
            // Truy vấn lấy Email trực tiếp từ bảng GiangVien thông qua MaGV trong đơn đặt
            string sql = $@"SELECT gv.Email FROM GiangVien gv 
                           JOIN LichDatPhong ld ON gv.MaGV = ld.MaGV 
                           WHERE ld.MaDatPhong = {maDatPhong}";
            DataTable dt = kn.ExecuteQuery(sql);
            if (dt.Rows.Count > 0 && dt.Rows[0]["Email"] != DBNull.Value)
            {
                return dt.Rows[0]["Email"].ToString().Trim();
            }
            return "";
        }
    }
}