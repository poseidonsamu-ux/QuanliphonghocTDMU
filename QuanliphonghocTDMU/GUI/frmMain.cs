using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmMain : Form
    {
        private Form activeForm = null;

        public frmMain()
        {
            InitializeComponent();
            CollapseAllSubMenus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // 1. FIX LỖI MẢNG MÀU TRẮNG CHE MẤT CHỮ
            pnlWelcome.BackColor = Color.Transparent;
            pnlWelcome.FillColor = Color.FromArgb(108, 40, 217);

            pnlSystemStatus.BackColor = Color.Transparent;
            pnlSystemStatus.FillColor = Color.White;

            lblLoiChao.BringToFront();
            lblHuongDan.BringToFront();
            btnStatusIcon.BringToFront();
            lblStatusTitle.BringToFront();
            lblStatusDesc.BringToFront();

            // 2. NẠP DỮ LIỆU THỰC TẾ CHO TRANG TỔNG QUAN
            LoadPendingRequests();
            LoadUrgentIncidents();

            // 3. XỬ LÝ PHÂN QUYỀN
            string role = frmDangNhap.Role;
            lblUserRole.Text = "Quyền: " + role;
            PhanQuyen(role);
            SetupLoiChao(role);
        }

        private void LoadPendingRequests()
        {
            // Nạp dữ liệu mẫu mượn phòng (hoặc lấy từ DB của bạn)
            DataTable dt = new DataTable();
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Giảng viên");
            dt.Columns.Add("Thời gian");

            dt.Rows.Add("B201", "ThS. Nguyễn Văn A", "07:30 - 09:15");
            dt.Rows.Add("C103", "TS. Lê Thị B", "09:30 - 11:15");
            dt.Rows.Add("B105", "ThS. Trần Văn C", "13:00 - 15:30");

            dgvPendingRequests.DataSource = dt;
        }

        private void LoadUrgentIncidents()
        {
            // Nạp dữ liệu mẫu sự cố thiết bị cần xử lý gấp
            DataTable dt = new DataTable();
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Sự cố khẩn cấp");
            dt.Columns.Add("Mức độ");

            dt.Rows.Add("B302", "Hỏng máy chiếu", "Cao");
            dt.Rows.Add("C101", "Mất kết nối mạng", "Trung bình");
            dt.Rows.Add("A205", "Hỏng điều hòa", "Cao");

            dgvUrgentIncidents.DataSource = dt;
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
        }

        // Chuyển hướng các form con
        private void btnDoiMatKhau_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Đổi Mật Khẩu"; openChildForm(new frmDoiMatKhau()); }
        private void btnToaNha_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Tòa Nhà"; openChildForm(new frmQuanLiToaNha()); }
        private void btnPhongHoc_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Phòng Học"; openChildForm(new frmQuanLiPhongHoc()); }
        private void btnThietBi_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Thiết Bị"; openChildForm(new frmQuanLiThietBi()); }
        private void btnGiangVien_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Quản lý Giảng Viên"; openChildForm(new frmQuanLiGiangVien()); }
        private void btnTraCuu_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Tra Cứu Lịch"; openChildForm(new frmTraCuu()); }
        private void btnDuyetYeuCau_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Duyệt Yêu Cầu"; openChildForm(new frmDuyetYeuCau()); }
        private void btnBaoCaoSuCo_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Báo Cáo Sự Cố"; openChildForm(new frmBaoCaoSuCo()); }
        private void btnThongKeSuDung_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Thống Kê Sử Dụng"; openChildForm(new frmThongKeSuDung()); }
        private void btnThongKeThietBi_Click(object sender, EventArgs e) { lblHeaderTitle.Text = "Thống Kê Thiết Bị"; openChildForm(new frmThongKeThietBi()); }
        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "Xuất Báo Cáo";
            openChildForm(new frmXuatBaoCao());
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
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
    }
}