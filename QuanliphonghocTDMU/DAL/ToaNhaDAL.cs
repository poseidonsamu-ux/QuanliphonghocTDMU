using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class ToaNhaDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachToaNha()
        {
            string sql = "SELECT MaToaNha AS [Mã Tòa Nhà], TenKhu AS [Tên Khu], SoTang AS [Số Tầng], GhiChu AS [Ghi Chú] FROM ToaNha";
            return kn.ExecuteQuery(sql);
        }

        public bool ThemToaNha(ToaNhaDTO tn)
        {
            string sql = string.Format("INSERT INTO ToaNha(MaToaNha, TenKhu, SoTang, GhiChu) VALUES ('{0}', N'{1}', {2}, N'{3}')",
                tn.MaToaNha, tn.TenKhu, tn.SoTang, tn.GhiChu);
            return kn.ExecuteNonQuery(sql);
        }

        public bool SuaToaNha(ToaNhaDTO tn)
        {
            // Lưu ý: Sửa thì không cho sửa Mã và Tên Khu (đã sinh tự động)
            string sql = string.Format("UPDATE ToaNha SET SoTang = {0}, GhiChu = N'{1}' WHERE MaToaNha = '{2}'",
                tn.SoTang, tn.GhiChu, tn.MaToaNha);
            return kn.ExecuteNonQuery(sql);
        }

        public bool XoaToaNha(string maToaNha)
        {
            string sql = string.Format("DELETE FROM ToaNha WHERE MaToaNha = '{0}'", maToaNha);
            return kn.ExecuteNonQuery(sql);
        }
    }
}