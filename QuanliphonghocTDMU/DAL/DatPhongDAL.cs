using System;
using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class DatPhongDAL
    {
        private KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachPhongSẵnSàng() => kn.ExecuteQuery("SELECT MaPhong, SucChua FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'");
        public DataTable LayDanhSachGiangVien() => kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");

        public DataTable LayChiTietGiangVien(string maGV)
        {
            return kn.ExecuteQuery($@"SELECT G.HoTen, K.TenKhoa, G.SoDienThoai FROM GiangVien G 
                                     JOIN KhoaVien K ON G.MaKhoa = K.MaKhoa WHERE G.MaGV = '{maGV}'");
        }

        public bool KiemTraTrungLich(string maPhong, DateTime ngay, int ca)
        {
            DataTable dt = kn.ExecuteQuery($@"SELECT * FROM LichDatPhong WHERE MaPhong='{maPhong}' 
                                            AND NgayDat='{ngay:yyyy-MM-dd}' AND CaHoc={ca} AND TrangThaiDuyet != N'Từ chối'");
            return dt.Rows.Count > 0;
        }

        public bool ThemDatPhong(LichDatPhongDTO dto)
        {
            string sql = $@"INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) 
                            VALUES('{dto.MaPhong}', '{dto.MaGV}', '{dto.NgayDat:yyyy-MM-dd}', 
                            {dto.CaHoc}, {dto.TietBatDau}, {dto.TietKetThuc}, N'{dto.MucDich}', N'{dto.TrangThaiDuyet}')";
            return kn.ExecuteNonQuery(sql);
        }

        public DataTable LayDanhSachToaNha()
        {
            DataTable dt = kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");
            DataRow dr = dt.NewRow();
            dr["MaToaNha"] = "ALL";
            dr["TenKhu"] = "-- Tất cả --";
            dt.Rows.InsertAt(dr, 0);
            return dt;
        }

        public DataTable GetDanhSachPhongAdmin(DateTime ngay, string ca, string maToaNha)
        {
            string ngayStr = ngay.ToString("yyyy-MM-dd");
            string dieuKienCa = (ca != "ALL") ? $" AND ld.CaHoc = {ca}" : "";
            string sql = $@"
                SELECT 
                       (SELECT TOP 1 ld.MaDatPhong FROM LichDatPhong ld WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa}) AS [MaDatPhong],
                       p.MaPhong AS [Phòng], p.LoaiPhong AS [Loại], p.SucChua AS [Sức chứa],
                       CASE WHEN EXISTS (SELECT 1 FROM LichDatPhong ld WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa}) THEN N'Đang bận' ELSE N'Trống' END AS [Trạng thái],
                       (SELECT TOP 1 gv.HoTen FROM LichDatPhong ld JOIN GiangVien gv ON ld.MaGV = gv.MaGV WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa}) AS [Giảng viên]
                FROM PhongHoc p WHERE 1=1 ";

            if (maToaNha != "ALL") sql += $" AND p.MaToaNha = '{maToaNha}'";
            return kn.ExecuteQuery(sql);
        }

        public bool XoaLichDatPhong(int maDatPhong) => kn.ExecuteNonQuery($"DELETE FROM LichDatPhong WHERE MaDatPhong = {maDatPhong}");

        // ĐÃ SỬA: Cho phép load "ALL" khu vực
        public DataTable LayDanhSachTrangThaiPhong(string maToaNha, DateTime ngay, string ca)
        {
            string ngayStr = ngay.ToString("yyyy-MM-dd");
            string dieuKienCa = (ca != "ALL") ? $" AND ld.CaHoc = {ca}" : "";
            string dieuKienToaNha = (maToaNha != "ALL") ? $" AND p.MaToaNha = '{maToaNha}'" : "";

            string sql = $@"
                SELECT p.MaPhong AS [Phòng], p.LoaiPhong AS [Loại], p.SucChua AS [Sức chứa],
                       CASE WHEN EXISTS (
                           SELECT 1 FROM LichDatPhong ld 
                           WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet != N'Từ chối' {dieuKienCa}
                       ) THEN N'Đang bận' ELSE N'Trống' END AS [Trạng thái]
                FROM PhongHoc p
                WHERE 1=1 {dieuKienToaNha}";
            return kn.ExecuteQuery(sql);
        }

        public DataTable GetThietBiPhong(string maPhong) => kn.ExecuteQuery($"SELECT tb.TenTB + ' (SL: ' + CAST(tbp.SoLuong AS VARCHAR) + ')' AS ThongTin FROM TrangBiPhong tbp JOIN ThietBi tb ON tbp.MaTB = tb.MaTB WHERE tbp.MaPhong = '{maPhong}'");
    }
}