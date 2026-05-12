using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDangNhap : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();
        public static string Role = "";
        public static string MaGV = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiKhoanDTO tk = bll.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);

            if (tk != null)
            {
                Role = tk.Quyen;
                MaGV = tk.MaGV;

                this.Hide();

                frmMain frm = new frmMain();

                DialogResult result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show();

                    txtTenDangNhap.Clear();
                    txtMatKhau.Clear();
                    txtTenDangNhap.Focus();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}