using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmMain : Form
    {
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Lấy quyền từ Form đăng nhập
            string role = frmDangNhap.Role;
            this.Text = "Hệ thống Quản lý Phòng học TDMU - Đang đăng nhập: " + role;

            PhanQuyen(role);
            SetupLoiChao(role);

            // Bắt buộc Menu luôn nằm trên cùng để không bị Panel đè mất
            mnuMain.BringToFront();
        }

        private void SetupLoiChao(string role)
        {
    
            if (role == "Admin")
            {
                lblLoiChao.Text = "Xin chào Admin!";
                lblLoiChao.ForeColor = Color.FromArgb(0, 126, 249); 
            }
            else if (role == "GiangVien")
            {
                lblLoiChao.Text = "Xin chào Giảng viên!";
                lblLoiChao.ForeColor = Color.FromArgb(95, 210, 161);
            }
            else
            {
                lblLoiChao.Text = "Xin chào!";
                lblLoiChao.ForeColor = Color.White;
            }

            lblHuongDan.Text = role == "Admin" ? "Hệ thống quản trị đã sẵn sàng." : "Vui lòng chọn chức năng để tiếp tục.";

            lblLoiChao.Visible = true;
            lblHuongDan.Visible = true;
            if (picHome != null) picHome.Visible = true;

            // Cập nhật màu nền cho Panel Content đồng bộ
            pnlContent.BackColor = Color.FromArgb(34, 33, 74);
        }

        private void PhanQuyen(string role)
        {
            // Giảng viên thì ẩn bớt menu quản trị
            if (role == "GiangVien")
            {
                if (menuQuanLyDanhMuc != null) menuQuanLyDanhMuc.Visible = false;
                if (menuDuyetYeuCau != null) menuDuyetYeuCau.Visible = false;
                if (menuThongKe != null) menuThongKe.Visible = false;
            }
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            // Ẩn lời chào và ảnh đi khi mở Form con
            if (lblLoiChao != null) lblLoiChao.Visible = false;
            if (lblHuongDan != null) lblHuongDan.Visible = false;
            if (picHome != null) picHome.Visible = false;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        // ================== CÁC SỰ KIỆN CLICK MENU ==================
        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangNhap f = new frmDangNhap();
            f.ShowDialog();
            this.Close();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap f = new frmDangNhap();
                f.ShowDialog();
                this.Close();
            }
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuToaNha_Click(object sender, EventArgs e) { openChildForm(new frmQuanLiToaNha()); }
        private void mnuPhongHoc_Click(object sender, EventArgs e) { openChildForm(new frmQuanLiPhongHoc()); }
        private void mnuThietBi_Click(object sender, EventArgs e) { openChildForm(new frmQuanLiThietBi()); }
        private void mnuGiangVien_Click(object sender, EventArgs e) { openChildForm(new frmQuanLiGiangVien()); }
        private void mnuTraCuu_Click(object sender, EventArgs e) { openChildForm(new frmTraCuu()); }
        private void menuDuyetYeuCau_Click(object sender, EventArgs e) { openChildForm(new frmDuyetYeuCau()); }
        private void mnuBaoCaoSuCo_Click(object sender, EventArgs e) { openChildForm(new frmBaoCaoSuCo()); }
        private void mnuThongKeSuDung_Click(object sender, EventArgs e) { openChildForm(new frmThongKeSuDung()); }
        private void mnuThongKeThietBi_Click(object sender, EventArgs e) { openChildForm(new frmThongKeThietBi()); }
        private void mnuXuatBaoCao_Click(object sender, EventArgs e) { openChildForm(new frmXuatBaoCao()); }
    }
}