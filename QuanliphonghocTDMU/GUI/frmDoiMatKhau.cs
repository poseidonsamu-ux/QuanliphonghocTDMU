using QuanLiPhongHocTDMU.BLL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDoiMatKhau : Form
    {
        TaiKhoanBLL bll = new TaiKhoanBLL();

        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (pnlContainer != null)
            {
                int x = (this.ClientSize.Width - pnlContainer.Width) / 2;
                int y = (this.ClientSize.Height - pnlContainer.Height) / 2;
                pnlContainer.Location = new Point(x, y);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string ketQua = bll.ThucHienDoiMatKhau(
                txtTenDangNhap.Text.Trim(),
                txtMatKhauCu.Text,
                txtMatKhauMoi.Text,
                txtXacNhan.Text
            );

            if (ketQua == "Thành công")
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Clear();
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtXacNhan.Clear();
                txtTenDangNhap.Focus();
            }
            else
            {
                MessageBox.Show(ketQua, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}