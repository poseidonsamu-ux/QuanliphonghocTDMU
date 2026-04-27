using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.DAL
{
    public class ThongKeThietBiDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDuLieuThongKe()
        {
            string sql = @"
                SELECT 
                    tb.TenTB AS [Tên Thiết Bị],
                    SUM(CASE WHEN tbp.TinhTrang = N'Bình thường' THEN tbp.SoLuong ELSE 0 END) AS [Số Lượng Tốt],
                    SUM(CASE WHEN tbp.TinhTrang = N'Hư hỏng' THEN tbp.SoLuong ELSE 0 END) AS [Số Lượng Hỏng],
                    SUM(tbp.SoLuong) AS [Tổng Số]
                FROM ThietBi tb
                LEFT JOIN TrangBiPhong tbp ON tb.MaTB = tbp.MaTB
                GROUP BY tb.TenTB";
            return kn.ExecuteQuery(sql);
        }
    }
}