using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();

        // Vẫn giữ lại 2 biến tĩnh này để làm cầu nối truyền dữ liệu sang frmMain
        public static string Role = "";
        public static string MaGV = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Gọi BLL để kiểm tra đăng nhập
            TaiKhoanDTO tk = bll.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);

            if (tk != null) // Nếu tk khác null => Có tài khoản trong CSDL
            {
                Role = tk.Quyen;
                MaGV = tk.MaGV;

                MessageBox.Show("Đăng nhập thành công với quyền: " + Role, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở Form Main
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}