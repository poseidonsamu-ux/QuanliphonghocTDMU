using System;
using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TraCuuDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable GetToaNha() => kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");

        // 1. ADMIN: Lấy danh sách phòng
        public DataTable GetDanhSachPhong(DateTime ngay, string ca, string maToaNha, bool chiLayPhongTrong)
        {
            string ngayStr = ngay.ToString("yyyy-MM-dd");
            string dieuKienCa = (ca != "ALL") ? $" AND ld.CaHoc = {ca}" : "";

            string sql = $@"
                SELECT p.MaPhong AS [Phòng], p.LoaiPhong AS [Loại], p.SucChua AS [Sức chứa],
                       CASE WHEN EXISTS (SELECT 1 FROM LichDatPhong ld WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa}) THEN N'Đang bận' ELSE N'Trống' END AS [Trạng thái],
                       (SELECT TOP 1 gv.HoTen FROM LichDatPhong ld JOIN GiangVien gv ON ld.MaGV = gv.MaGV WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa}) AS [Giảng viên]
                FROM PhongHoc p WHERE 1=1 ";

            if (maToaNha != "ALL") sql += $" AND p.MaToaNha = '{maToaNha}'";
            if (chiLayPhongTrong) sql += $@" AND NOT EXISTS (SELECT 1 FROM LichDatPhong ld WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa})";

            return kn.ExecuteQuery(sql);
        }

        // 2. Lấy yêu cầu mượn phòng (Chung cho Admin và GV)
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

        // 3. ADMIN: Cập nhật duyệt/từ chối
        public bool CapNhatTrangThaiYeuCau(int maDatPhong, string trangThai) => kn.ExecuteNonQuery($"UPDATE LichDatPhong SET TrangThaiDuyet = N'{trangThai}' WHERE MaDatPhong = {maDatPhong}");

        // 4. ADMIN: Cảnh báo xung đột
        public DataTable GetXungDotLich()
        {
            string sql = @"SELECT l1.NgayDat AS [Ngày], l1.CaHoc AS [Ca], l1.MaPhong AS [Phòng Trùng], g1.HoTen AS [GV 1], g2.HoTen AS [GV 2] FROM LichDatPhong l1 JOIN LichDatPhong l2 ON l1.NgayDat = l2.NgayDat AND l1.CaHoc = l2.CaHoc AND l1.MaPhong = l2.MaPhong AND l1.MaDatPhong < l2.MaDatPhong JOIN GiangVien g1 ON l1.MaGV = g1.MaGV JOIN GiangVien g2 ON l2.MaGV = g2.MaGV WHERE l1.TrangThaiDuyet = N'Đã duyệt' AND l2.TrangThaiDuyet = N'Đã duyệt'";
            return kn.ExecuteQuery(sql);
        }

        // 5. ADMIN: Xem chi tiết sự cố và thiết bị
        public DataTable GetThietBiPhong(string maPhong) => kn.ExecuteQuery($"SELECT tb.TenTB + ' (SL: ' + CAST(tbp.SoLuong AS VARCHAR) + ')' AS ThongTin FROM TrangBiPhong tbp JOIN ThietBi tb ON tbp.MaTB = tb.MaTB WHERE tbp.MaPhong = '{maPhong}'");
        public DataTable GetSuCoPhong(string maPhong) => kn.ExecuteQuery($"SELECT NgayBaoCao, MoTa, TrangThai FROM BaoCaoSuCo WHERE MaPhong = '{maPhong}' ORDER BY NgayBaoCao DESC");

        // 6. GIẢNG VIÊN: Thuật toán Random
        public string LayPhongRandomTheoYeuCau(string ngay, int ca, string loaiPhong, int sucChua)
        {
            string sql = $@"
        SELECT TOP 1 MaPhong FROM PhongHoc 
        WHERE LoaiPhong = N'{loaiPhong}' 
          AND SucChua >= {sucChua}  -- THÊM ĐIỀU KIỆN SỨC CHỨA VÀO ĐÂY
          AND MaPhong NOT IN (SELECT MaPhong FROM LichDatPhong WHERE NgayDat = '{ngay}' AND CaHoc = {ca} AND TrangThaiDuyet != N'Từ chối')
        ORDER BY NEWID()";

            DataTable dt = kn.ExecuteQuery(sql);
            if (dt.Rows.Count > 0) return dt.Rows[0]["MaPhong"].ToString();
            return null;
        }

        public bool LuuYeuCauBocPhong(DTO.YeuCauBocPhongDTO yc)
        {
            string sql = $"INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, MucDich, TrangThaiDuyet) VALUES ('{yc.MaPhong}', '{yc.MaGV}', '{yc.NgayDat}', {yc.CaHoc}, N'{yc.MucDich}', N'{yc.TrangThaiDuyet}')";
            return kn.ExecuteNonQuery(sql);
        }

        // 7. Lấy Email của giảng viên dựa trên Mã đặt phòng (Dùng cho gửi mail thông báo)
        public string GetEmailGiangVienByMaDat(int maDatPhong)
        {
            // Truy vấn kết nối bảng LichDatPhong và GiangVien để lấy đúng Email của người đặt
            string sql = $@"
        SELECT gv.Email 
        FROM GiangVien gv
        JOIN LichDatPhong ld ON gv.MaGV = ld.MaGV
        WHERE ld.MaDatPhong = {maDatPhong}";

            DataTable dt = kn.ExecuteQuery(sql);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Email"].ToString();
            }
            return ""; // Trả về rỗng nếu không tìm thấy
        }
    }
}