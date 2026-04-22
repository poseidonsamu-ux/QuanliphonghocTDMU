using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class BaoCaoSuCoDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachPhong()
        {
            return kn.ExecuteQuery("SELECT MaPhong, TenPhong FROM PhongHoc");
        }

        public DataTable LayThietBiTheoPhong(string maPhong)
        {
            string sql = string.Format(@"
                SELECT tb.MaTB AS [Mã TB], tb.TenTB AS [Tên Thiết Bị], 
                       tbp.SoLuong AS [Số Lượng], tbp.TinhTrang AS [Tình Trạng]
                FROM TrangBiPhong tbp
                JOIN ThietBi tb ON tbp.MaTB = tb.MaTB
                WHERE tbp.MaPhong = '{0}'", maPhong);
            return kn.ExecuteQuery(sql);
        }

        public bool CapNhatTinhTrang(string maPhong, string maTB, string tinhTrang)
        {
            string sql = string.Format("UPDATE TrangBiPhong SET TinhTrang = N'{0}' WHERE MaPhong = '{1}' AND MaTB = '{2}'",
                                        tinhTrang, maPhong, maTB);
            return kn.ExecuteNonQuery(sql);
        }
    }
}