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
            // Lấy quyền từ Form Đăng Nhập truyền sang
            string role = frmDangNhap.Role;

            // Đổi tiêu đề phần mềm để biết ai đang đăng nhập
            this.Text = "Hệ thống Quản lý Phòng học TDMU - Đang đăng nhập: " + role;

            PhanQuyen(role);
            LoadDashboard();
        }

        private void PhanQuyen(string role)
        {
            if (role == "GiangVien")
            {
                menuQuanLyDanhMuc.Visible = false;
                menuDuyetYeuCau.Visible = false;
                menuThongKe.Visible = false; // Giảng viên không được xem thống kê tổng
            }
        }

        private void LoadDashboard()
        {
            openChildForm(new frmTrangChu());
        }

        // ĐÃ SỬA THÀNH PUBLIC Ở ĐÂY ĐỂ CÁC FORM KHÁC GỌI ĐƯỢC
        public void openChildForm(Form childForm)
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

        // ================== MENU HỆ THỐNG ==================
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDangNhap());
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            MessageBox.Show("Đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Xử lý chuyển về form đăng nhập sau
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }

        private void mnuCauHinh_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCauHinh());
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ================== MENU DANH MỤC ==================
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

        // ================== MENU NGHIỆP VỤ ==================

        private void mnuTraCuu_Click(object sender, EventArgs e)
        {
            openChildForm(new frmTraCuu());
        }

        private void menuDuyetYeuCau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDuyetYeuCau());
        }

        private void mnuBaoCaoSuCo_Click(object sender, EventArgs e)
        {
            openChildForm(new frmBaoCaoSuCo());
        }

        private void mnuCheckInQR_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCheckInQR());
        }

        // ================== MENU THỐNG KÊ ==================
        private void mnuThongKeSuDung_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeSuDung());
        }

        private void mnuThongKeThietBi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeThietBi());
        }

        private void mnuXuatBaoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXuatBaoCao());
        }
    }
}