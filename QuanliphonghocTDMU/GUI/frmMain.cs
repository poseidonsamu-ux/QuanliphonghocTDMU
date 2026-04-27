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
                lblHuongDan.Text = "Hãy lựa chọn các chức năng quản trị hệ thống bên dưới để bắt đầu công việc.";
                lblLoiChao.ForeColor = System.Drawing.Color.DodgerBlue;
            }
            else if (role == "GiangVien")
            {
                lblLoiChao.Text = "Xin chào Giảng viên!";
                lblHuongDan.Text = "Bạn hãy lựa chọn các chức năng để cập nhật lịch dạy, báo cáo sự cố hoặc tra cứu thiết bị phòng học.";
                lblLoiChao.ForeColor = System.Drawing.Color.SeaGreen;
            }
            else
            {
                lblLoiChao.Text = "Xin chào!";
                lblHuongDan.Text = "Vui lòng chọn chức năng từ menu để tiếp tục.";
            }

            lblLoiChao.Visible = true;
            lblHuongDan.Visible = true;
            if (picHome != null) picHome.Visible = true;
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