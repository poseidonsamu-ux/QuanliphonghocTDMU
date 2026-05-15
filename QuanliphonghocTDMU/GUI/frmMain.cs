using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using QuanLiPhongHocTDMU.GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmMain : Form
    {
        private Form activeForm = null;
        private TrangChuBLL bllTrangChu = new TrangChuBLL();

        public frmMain()
        {
            InitializeComponent();
            CollapseAllSubMenus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlWelcome.BackColor = Color.Transparent;
            pnlWelcome.FillColor = Color.FromArgb(108, 40, 217);
            pnlSystemStatus.BackColor = Color.Transparent;
            pnlSystemStatus.FillColor = Color.White;

            lblLoiChao.BringToFront();
            lblHuongDan.BringToFront();
            btnStatusIcon.BringToFront();
            lblStatusTitle.BringToFront();
            lblStatusDesc.BringToFront();

            LoadPendingRequests();
            LoadUrgentIncidents();

            string role = frmDangNhap.Role;
            lblUserRole.Text = "Quyền: " + role;
            PhanQuyen(role);
            SetupLoiChao(role);
        }

        private void LoadPendingRequests()
        {
            try
            {
                List<YeuCauMoiNhatDTO> dsYeuCau = bllTrangChu.LayYeuCauMoiNhat();
                dgvPendingRequests.DataSource = dsYeuCau;

                // Set tên cột tiếng Việt (vì DTO dạng cơ bản)
                dgvPendingRequests.Columns["Phong"].HeaderText = "Phòng";
                dgvPendingRequests.Columns["GiangVien"].HeaderText = "Giảng viên";
                dgvPendingRequests.Columns["ThoiGian"].HeaderText = "Thời gian";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu Yêu cầu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUrgentIncidents()
        {
            try
            {
                List<SuCoKhanCapDTO> dsSuCo = bllTrangChu.LaySuCoKhanCap();
                dgvUrgentIncidents.DataSource = dsSuCo;

                // Set tên cột tiếng Việt (vì DTO dạng cơ bản)
                dgvUrgentIncidents.Columns["Phong"].HeaderText = "Phòng";
                dgvUrgentIncidents.Columns["SuCo"].HeaderText = "Sự cố khẩn cấp";
                dgvUrgentIncidents.Columns["MucDo"].HeaderText = "Mức độ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu Sự cố: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupLoiChao(string role)
        {
            if (role == "Admin")
            {
                lblLoiChao.Text = "Chào mừng trở lại, Admin! 👋";
                lblHuongDan.Text = "Hệ thống Quản lý Phòng học TDMU đã sẵn sàng hoạt động.";
            }
            else
            {
                lblLoiChao.Text = "Xin chào, Giảng viên! 👋";
                lblHuongDan.Text = "Vui lòng sử dụng chức năng Nghiệp Vụ bên trái để mượn phòng hoặc báo cáo sự cố.";
            }
        }

        private void PhanQuyen(string role)
        {
            if (role == "GiangVien")
            {
                btnDanhMuc.Visible = false;
                pnlSubDanhMuc.Visible = false;
                btnThongKe.Visible = false;
                pnlSubThongKe.Visible = false;
                btnDuyetYeuCau.Visible = false;
                btnTraCuu.Visible = false;

                // Ẩn nút cấp tài khoản với quyền Giảng Viên
                btnCapTaiKhoan.Visible = false;
            }
        }

        private void CollapseAllSubMenus()
        {
            pnlSubHeThong.Visible = false;
            pnlSubDanhMuc.Visible = false;
            pnlSubNghiepVu.Visible = false;
            pnlSubThongKe.Visible = false;
        }

        private void ToggleSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                CollapseAllSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e) { ToggleSubMenu(pnlSubHeThong); }
        private void btnDanhMuc_Click(object sender, EventArgs e) { ToggleSubMenu(pnlSubDanhMuc); }
        private void btnNghiepVu_Click(object sender, EventArgs e) { ToggleSubMenu(pnlSubNghiepVu); }
        private void btnThongKe_Click(object sender, EventArgs e) { ToggleSubMenu(pnlSubThongKe); }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            pnlDashboardContainer.Visible = false;

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(childForm);
            pnlContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            pnlDashboardContainer.Visible = true;
            lblHeaderTitle.Text = "Tổng quan thống kê";
            CollapseAllSubMenus();

            LoadPendingRequests();
            LoadUrgentIncidents();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Đổi Mật Khẩu"; openChildForm(new frmDoiMatKhau()); }
        private void btnToaNha_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Tòa Nhà"; openChildForm(new frmQuanLiToaNha()); }
        private void btnPhongHoc_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Phòng Học"; openChildForm(new frmQuanLiPhongHoc()); }
        private void btnThietBi_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Thiết Bị"; openChildForm(new frmQuanLiThietBi()); }
        private void btnGiangVien_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Giảng Viên"; openChildForm(new frmQuanLiGiangVien()); }

        // Các form nghiệp vụ
        private void btnTraCuu_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Tra Cứu Lịch"; openChildForm(new frmTraCuu()); }

        // Thêm sự kiện cho nút Đặt Phòng
        private void btnDatPhong_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Đặt Phòng Học"; openChildForm(new frmDatPhong()); }

        private void btnDuyetYeuCau_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Duyệt Yêu Cầu"; openChildForm(new frmDuyetYeuCau()); }

        // Thêm sự kiện cho nút Cấp Tài Khoản
        private void btnCapTaiKhoan_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Cấp Tài Khoản Hệ Thống"; /* openChildForm(new frmQuanLiTaiKhoan()); */ }

        private void btnBaoCaoSuCo_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Báo Cáo Sự Cố"; openChildForm(new frmBaoCaoSuCo()); }

        // Các form thống kê
        private void btnThongKeSuDung_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Thống Kê Sử Dụng"; openChildForm(new frmThongKeSuDung()); }

        private void btnThongKeSuCo_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Thống Kê Sự Cố"; openChildForm(new frmThongKeSuCo()); }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "Xuất Báo Cáo";
            openChildForm(new frmXuatBaoCao());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}