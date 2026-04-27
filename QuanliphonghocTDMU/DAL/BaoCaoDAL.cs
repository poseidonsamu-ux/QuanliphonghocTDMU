using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class BaoCaoDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayLichSuMuonPhong()
        {
            string sql = @"
                SELECT 
                    p.TenPhong AS [Tên Phòng], 
                    g.HoTen AS [Giảng Viên], 
                    l.NgayDat AS [Ngày Đặt], 
                    l.CaHoc AS [Ca], 
                    l.MucDich AS [Mục Đích]
                FROM LichDatPhong l
                JOIN PhongHoc p ON l.MaPhong = p.MaPhong
                JOIN GiangVien g ON l.MaGV = g.MaGV
                ORDER BY l.NgayDat DESC";
            return kn.ExecuteQuery(sql);
        }
    }
}