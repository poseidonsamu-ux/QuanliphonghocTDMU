using System;
using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TraCuuDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable GetToaNha() => kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");


        public DataTable GetDanhSachPhong(DateTime ngay, string ca, string maToaNha, bool chiLayPhongTrong)
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
            if (chiLayPhongTrong) sql += $@" AND NOT EXISTS (SELECT 1 FROM LichDatPhong ld WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.TrangThaiDuyet = N'Đã duyệt' {dieuKienCa})";

            return kn.ExecuteQuery(sql);
        }

        // Hàm xóa lịch đặt phòng
        public bool XoaLichDatPhong(int maDatPhong)
        {
            string sql = $"DELETE FROM LichDatPhong WHERE MaDatPhong = {maDatPhong}";
            return kn.ExecuteNonQuery(sql);
        }

        public DataTable GetThietBiPhong(string maPhong) => kn.ExecuteQuery($"SELECT tb.TenTB + ' (SL: ' + CAST(tbp.SoLuong AS VARCHAR) + ')' AS ThongTin FROM TrangBiPhong tbp JOIN ThietBi tb ON tbp.MaTB = tb.MaTB WHERE tbp.MaPhong = '{maPhong}'");
        public DataTable GetSuCoPhong(string maPhong) => kn.ExecuteQuery($"SELECT NgayBaoCao, MoTa, TrangThai FROM BaoCaoSuCo WHERE MaPhong = '{maPhong}' ORDER BY NgayBaoCao DESC");
    }
}