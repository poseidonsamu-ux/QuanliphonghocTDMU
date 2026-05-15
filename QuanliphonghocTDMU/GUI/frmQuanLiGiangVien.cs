using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiGiangVien : Form
    {
        GiangVienBLL bll = new GiangVienBLL();
        string action = "";

        public frmQuanLiGiangVien() { InitializeComponent(); }

        private void frmQuanLiGiangVien_Load(object sender, EventArgs e)
        {
            try
            {
                TaiDuLieuKhoa();
                TaiDanhSach();
                TrangThaiBanDau();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 1. Hàm hỗ trợ
        private void TaiDanhSach() { dgvGiangVien.DataSource = bll.LayGiangVien(); }

        private void TaiDuLieuKhoa()
        {
            cmbKhoa.DataSource = bll.LayKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void TrangThaiBanDau()
        {
            action = "";
            txtMaGV.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtEmail.Clear();
            txtMaGV.Enabled = false;
            btnThem.Enabled = true; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = false; btnHuy.Enabled = false;
            dgvGiangVien.Enabled = true;
        }

        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = true; btnHuy.Enabled = true;
            dgvGiangVien.Enabled = false;
        }

        // 2. Nghiệp vụ CRUD
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaGV.Clear(); txtMaGV.Enabled = true; txtMaGV.Focus();
            BatCheDoThaoTac();
        }

        private void btnSua_Click(object sender, EventArgs e) { action = "Sua"; BatCheDoThaoTac(); }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            action = "Xoa";
            BatCheDoThaoTac();
            MessageBox.Show("Vui lòng nhấn LƯU để xác nhận XÓA!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaGV.Text) && action != "Xoa") { MessageBox.Show("Vui lòng nhập Mã GV!"); return; }

                GiangVienDTO gv = new GiangVienDTO
                {
                    MaGV = txtMaGV.Text.Trim(),
                    HoTen = txtHoTen.Text.Trim(),
                    MaKhoa = cmbKhoa.SelectedValue.ToString(),
                    SoDienThoai = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim()
                };

                bool kq = false;
                if (action == "Them") kq = bll.Them(gv);
                else if (action == "Sua") kq = bll.Sua(gv);
                else if (action == "Xoa")
                {
                    if (MessageBox.Show("Xác nhận xóa giảng viên này?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        kq = bll.Xoa(txtMaGV.Text);
                    else { TrangThaiBanDau(); return; }
                }

                if (kq)
                {
                    MessageBox.Show("Thành công!");
                    TaiDanhSach(); TrangThaiBanDau();
                }
                else MessageBox.Show("Thất bại!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e) { TrangThaiBanDau(); }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                txtMaGV.Text = dgvGiangVien.Rows[r].Cells["Mã GV"].Value?.ToString();
                txtHoTen.Text = dgvGiangVien.Rows[r].Cells["Họ Tên"].Value?.ToString();
                cmbKhoa.Text = dgvGiangVien.Rows[r].Cells["Khoa/Viện"].Value?.ToString();
                txtSDT.Text = dgvGiangVien.Rows[r].Cells["SĐT"].Value?.ToString();
                txtEmail.Text = dgvGiangVien.Rows[r].Cells["Email"].Value?.ToString();
                btnSua.Enabled = true; btnXoa.Enabled = true;
            }
        }

        // 3. Nghiệp vụ EXCEL
        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook (*.xlsx)|*.xlsx", FileName = "Mau_GiangVien.xlsx" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bll.TaiMau(sfd.FileName);
                    MessageBox.Show("Đã tải mẫu!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int n = bll.NhapExcel(ofd.FileName);
                    MessageBox.Show($"Thành công {n} dòng.");
                    TaiDanhSach();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try { bll.XuatExcel(dgvGiangVien); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}