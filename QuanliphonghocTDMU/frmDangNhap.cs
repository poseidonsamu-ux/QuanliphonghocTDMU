using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDangNhap : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        // Biến toàn cục để các Form khác có thể gọi và biết ai đang đăng nhập
        public static string Role = "";
        public static string MaGV = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = string.Format("SELECT Quyen, MaGV FROM TaiKhoan WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'",
                                        txtTenDangNhap.Text, txtMatKhau.Text);
            DataTable dt = kn.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                // Lưu lại thông tin người dùng hiện tại
                Role = dt.Rows[0]["Quyen"].ToString();
                MaGV = dt.Rows[0]["MaGV"].ToString();

                MessageBox.Show("Đăng nhập thành công với quyền: " + Role, "Thông báo");

                // Mở Form Main
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide(); // Ẩn form đăng nhập đi
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