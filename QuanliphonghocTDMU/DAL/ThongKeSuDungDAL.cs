using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class ThongKeSuDungDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDuLieuThongKe()
        {
            // Đếm số lần xuất hiện của MaPhong trong bảng LichDatPhong
            string sql = @"
                SELECT 
                    p.MaPhong AS [Mã Phòng], 
                    p.TenPhong AS [Tên Phòng], 
                    COUNT(l.MaDatPhong) AS [Tổng Số Lượt Dùng],
                    MAX(l.NgayDat) AS [Ngày Sử Dụng Gần Nhất]
                FROM PhongHoc p
                LEFT JOIN LichDatPhong l ON p.MaPhong = l.MaPhong AND l.TrangThaiDuyet = N'Đã duyệt'
                GROUP BY p.MaPhong, p.TenPhong
                ORDER BY COUNT(l.MaDatPhong) DESC"; // Sắp xếp phòng dùng nhiều nhất lên đầu
            return kn.ExecuteQuery(sql);
        }
    }
}