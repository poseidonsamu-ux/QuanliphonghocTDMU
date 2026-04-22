using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class ThietBiDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachThietBi()
        {
            string sql = "SELECT MaTB AS [Mã TB], TenTB AS [Tên Thiết Bị], LoaiTB AS [Loại] FROM ThietBi";
            return kn.ExecuteQuery(sql);
        }

        public bool ThemThietBi(ThietBiDTO tb)
        {
            string sql = string.Format("INSERT INTO ThietBi VALUES ('{0}', N'{1}', N'{2}')", tb.MaTB, tb.TenTB, tb.LoaiTB);
            return kn.ExecuteNonQuery(sql);
        }

        public bool SuaThietBi(ThietBiDTO tb)
        {
            string sql = string.Format("UPDATE ThietBi SET TenTB = N'{0}', LoaiTB = N'{1}' WHERE MaTB = '{2}'", tb.TenTB, tb.LoaiTB, tb.MaTB);
            return kn.ExecuteNonQuery(sql);
        }

        public bool XoaThietBi(string maTB)
        {
            string sql = string.Format("DELETE FROM ThietBi WHERE MaTB = '{0}'", maTB);
            return kn.ExecuteNonQuery(sql);
        }
    }
}