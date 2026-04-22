using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TaiKhoanDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        // --- DÀNH CHO FORM ĐĂNG NHẬP ---
        public TaiKhoanDTO KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string sql = string.Format("SELECT Quyen, MaGV FROM TaiKhoan WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", tenDangNhap, matKhau);
            DataTable dt = kn.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenDangNhap = tenDangNhap;
                tk.MatKhau = matKhau;
                tk.Quyen = dt.Rows[0]["Quyen"].ToString();
                tk.MaGV = dt.Rows[0]["MaGV"].ToString();
                return tk;
            }
            return null;
        }

        // --- DÀNH CHO FORM ĐỔI MẬT KHẨU ---
        public bool KiemTraMatKhauCu(string tenDangNhap, string matKhauCu)
        {
            string sql = string.Format("SELECT * FROM TaiKhoan WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'", tenDangNhap, matKhauCu);
            DataTable dt = kn.ExecuteQuery(sql);
            return dt.Rows.Count > 0;
        }

        public bool CapNhatMatKhau(string tenDangNhap, string matKhauMoi)
        {
            string sql = string.Format("UPDATE TaiKhoan SET MatKhau = '{0}' WHERE TenDangNhap = '{1}'", matKhauMoi, tenDangNhap);
            return kn.ExecuteNonQuery(sql);
        }
    }
}