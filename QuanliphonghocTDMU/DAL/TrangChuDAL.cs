using System;
using System.Data;
using System.Collections.Generic;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TrangChuDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayThongKe()
        {
            string sql = @"
                SELECT 
                    (SELECT COUNT(DISTINCT MaPhong) FROM LichDatPhong WHERE NgayDat = CAST(GETDATE() AS DATE) AND TrangThaiDuyet = N'Đã duyệt') as DangDung,
                    ((SELECT COUNT(*) FROM PhongHoc WHERE TrangThai = N'Sẵn sàng') - (SELECT COUNT(DISTINCT MaPhong) FROM LichDatPhong WHERE NgayDat = CAST(GETDATE() AS DATE) AND TrangThaiDuyet = N'Đã duyệt')) as PhongTrong,
                    (SELECT COUNT(*) FROM LichDatPhong WHERE TrangThaiDuyet = N'Chờ duyệt') as ChoDuyet";
            return kn.ExecuteQuery(sql);
        }

        public DataTable LayLichDayGV(string maGV)
        {
            string sql = string.Format(@"
                SELECT p.TenPhong, l.CaHoc, l.MucDich, l.TrangThaiDuyet
                FROM LichDatPhong l
                JOIN PhongHoc p ON l.MaPhong = p.MaPhong
                WHERE l.MaGV = '{0}' AND l.NgayDat = CAST(GETDATE() AS DATE)
                ORDER BY l.CaHoc ASC", maGV);
            return kn.ExecuteQuery(sql);
        }
    }
}