using QuanLiPhongHocTDMU;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmMain : Form
    {
        private string roleHienTai = "Admin";
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen(roleHienTai);
            LoadDashboard();
        }

        private void PhanQuyen(string role)
        {
            if (role == "GiangVien")
            {
                menuQuanLyDanhMuc.Visible = false;
                menuDuyetYeuCau.Visible = false;
            }
        }

        private void LoadDashboard()
        {
            // Code load giao diện trang chủ sau này
        }

        // Hàm lõi: Dùng để nhúng Form con vào giữa Panel của Form Main
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // --- CÁC NÚT MENU QUẢN LÝ DANH MỤC ---
        private void mnuToaNha_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLiToaNha());
        }

        private void mnuPhongHoc_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLiPhongHoc());
        }

        private void mnuThietBi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLiThietBi());
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLiGiangVien());
        }

        // --- CÁC NÚT MENU NGHIỆP VỤ ---
        private void mnuDatPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDatPhong());
        }

        private void mnuTraCuu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTraCuu());
        }

        private void menuDuyetYeuCau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDuyetYeuCau());
        }

        // --- HỆ THỐNG ---
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}