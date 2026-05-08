using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTraCuu : Form
    {
        TraCuuBLL bll = new TraCuuBLL();
        string role = "";
        string maGV = "";

        public frmTraCuu() { InitializeComponent(); }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {
            // Lấy thông tin từ Form Đăng Nhập
            role = frmDangNhap.Role;
            maGV = frmDangNhap.MaGV;

            // Load Combobox Admin
            cmbCaHoc.Items.AddRange(new object[] { "ALL", "1", "2", "3" });
            cmbCaHoc.SelectedIndex = 0;
            cmbToaNha.DataSource = bll.GetToaNhaCombobox();
            cmbToaNha.DisplayMember = "TenKhu"; cmbToaNha.ValueMember = "MaToaNha";

            // Load Combobox Giảng Viên
            cmbCaGV.Items.AddRange(new object[] { "1", "2", "3" });
            cmbCaGV.SelectedIndex = 0;
            cmbLoaiPhongGV.Items.AddRange(new object[] { "Phòng thường", "Phòng máy", "Giảng đường", "Phòng thí nghiệm", "Hội trường" });
            cmbLoaiPhongGV.SelectedIndex = 0;

            // XỬ LÝ PHÂN QUYỀN
            if (role == "GiangVien")
            {
                tabMain.TabPages.Remove(tabTraCuuAdmin);
                tabMain.TabPages.Remove(tabQuyTrinhAdmin);
                tabMain.TabPages.Remove(tabXungDotAdmin);
                pnlTopAdmin.Visible = false;
                splitContainer1.Panel2Collapsed = true;
                LoadLichSuGV();
            }
            else // Admin
            {
                tabMain.TabPages.Remove(tabBocPhongGV);
                tabMain.TabPages.Remove(tabLichSuGV);
                btnTimKiem_Click(null, null);
            }
        }

        // ---------- CHỨC NĂNG ADMIN ----------
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = bll.GetDanhSachPhong(dtpNgay.Value, cmbCaHoc.Text, cmbToaNha.SelectedValue.ToString(), false);
            dgvYeuCau.DataSource = bll.GetYeuCau(maGV, role);
            dgvXungDot.DataSource = bll.GetXungDot();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPhong.Columns.Contains("Phòng"))
            {
                string maP = dgvPhong.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();
                lblChiTiet.Text = $"CHI TIẾT PHÒNG: {maP}\n\n" + bll.GetChiTietPhong(maP);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e) => XuLyYeuCauAdmin("Đã duyệt");
        private void btnTuChoi_Click(object sender, EventArgs e) => XuLyYeuCauAdmin("Từ chối");

        private void XuLyYeuCauAdmin(string trangThai)
        {
            if (dgvYeuCau.CurrentRow != null)
            {
                int maDat = Convert.ToInt32(dgvYeuCau.CurrentRow.Cells["Mã YC"].Value);
                if (bll.DuyetYeuCau(maDat, trangThai)) { MessageBox.Show("Đã cập nhật!"); btnTimKiem_Click(null, null); }
            }
        }

        // ---------- CHỨC NĂNG GIẢNG VIÊN ----------
        private void LoadLichSuGV() => dgvLichSuGV.DataSource = bll.GetYeuCau(maGV, "GiangVien");

        private void btnTienHanhBocPhong_Click(object sender, EventArgs e)
        {
            string ketQua = bll.ThucHienBocPhong(dtpNgayGV.Value, cmbCaGV.Text, cmbLoaiPhongGV.Text, txtMucDichGV.Text, maGV);
            if (ketQua.StartsWith("THÀNH CÔNG"))
            {
                MessageBox.Show(ketQua.Split('|')[1], "🎉 Chúc mừng");
                txtMucDichGV.Clear(); LoadLichSuGV();
            }
            else MessageBox.Show(ketQua, "Cảnh báo");
        }
    }
}