using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TaiKhoanBLL
    {
        TaiKhoanDAL dal = new TaiKhoanDAL();

        // --- DÀNH CHO FORM ĐĂNG NHẬP ---
        public TaiKhoanDTO DangNhap(string tenDangNhap, string matKhau)
        {
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                return null;
            }
            return dal.KiemTraDangNhap(tenDangNhap, matKhau);
        }

        // --- DÀNH CHO FORM ĐỔI MẬT KHẨU ---
        public string ThucHienDoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi, string xacNhan)
        {
            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi))
                return "Vui lòng nhập đầy đủ thông tin!";

            // 2. Kiểm tra mật khẩu xác nhận
            if (matKhauMoi != xacNhan)
                return "Mật khẩu xác nhận không khớp!";

            // 3. Kiểm tra mật khẩu cũ dưới DB
            if (!dal.KiemTraMatKhauCu(tenDangNhap, matKhauCu))
                return "Tên đăng nhập hoặc mật khẩu cũ không chính xác!";

            // 4. Cho phép cập nhật
            if (dal.CapNhatMatKhau(tenDangNhap, matKhauMoi))
                return "Thành công";
            else
                return "Lỗi hệ thống khi cập nhật mật khẩu!";
        }
    }
}