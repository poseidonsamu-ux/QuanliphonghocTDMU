using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiThietBi : Form
    {
        ThietBiBLL bll = new ThietBiBLL();
        string action = "";

        public frmQuanLiThietBi() { InitializeComponent(); }

        private void frmQuanLiThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                cmbLoaiTB.Items.AddRange(new string[] { "Điện tử", "Điện lạnh", "Âm thanh", "Mạng", "Nội thất", "Thí nghiệm", "An toàn", "Phụ kiện" });
                LoadData();
                TrangThaiBanDau();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 1. Các hàm hỗ trợ giao diện
        private void LoadData() { dgvThietBi.DataSource = bll.GetThietBi(); }

        private void TrangThaiBanDau()
        {
            action = "";
            txtMaTB.Clear(); txtTenTB.Clear();
            txtMaTB.Enabled = false;
            if (cmbLoaiTB.Items.Count > 0) cmbLoaiTB.SelectedIndex = 0;

            btnThem.Enabled = true; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = false; btnHuy.Enabled = false;
            dgvThietBi.Enabled = true;
        }

        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = true; btnHuy.Enabled = true;
            dgvThietBi.Enabled = false;
        }

        // 2. Nghiệp vụ Thêm - Sửa - Xóa - Lưu
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaTB.Clear(); txtTenTB.Clear();
            txtMaTB.Enabled = true; txtMaTB.Focus();
            BatCheDoThaoTac();
        }

        private void btnSua_Click(object sender, EventArgs e) { action = "Sua"; BatCheDoThaoTac(); }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            action = "Xoa"; BatCheDoThaoTac();
            MessageBox.Show("Nhấn LƯU để xác nhận xóa thiết bị này!", "Thông báo");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaTB.Text)) { MessageBox.Show("Vui lòng nhập Mã Thiết Bị!"); return; }

                ThietBiDTO tb = new ThietBiDTO
                {
                    MaTB = txtMaTB.Text.Trim(),
                    TenTB = txtTenTB.Text.Trim(),
                    LoaiTB = cmbLoaiTB.Text
                };

                bool kq = false;
                if (action == "Them") kq = bll.Them(tb);
                else if (action == "Sua") kq = bll.Sua(tb);
                else if (action == "Xoa") kq = bll.Xoa(txtMaTB.Text);

                if (kq)
                {
                    MessageBox.Show("Thao tác thành công!");
                    LoadData(); TrangThaiBanDau();
                }
                else MessageBox.Show("Thất bại! Vui lòng kiểm tra lại.");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e) { TrangThaiBanDau(); }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                txtMaTB.Text = dgvThietBi.Rows[r].Cells["Mã TB"].Value?.ToString();
                txtTenTB.Text = dgvThietBi.Rows[r].Cells["Tên Thiết Bị"].Value?.ToString();
                cmbLoaiTB.Text = dgvThietBi.Rows[r].Cells["Loại"].Value?.ToString();
                btnSua.Enabled = true; btnXoa.Enabled = true;
            }
        }

        // 3. Logic xử lý EXCEL
        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel|*.xlsx", FileName = "Mau_ThietBi.xlsx" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bll.TaiMau(sfd.FileName);
                    MessageBox.Show("Đã tải file mẫu thành công!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel|*.xlsx;*.xls" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int sl = bll.NhapExcel(ofd.FileName);
                    MessageBox.Show($"Đã nhập thành công {sl} thiết bị!");
                    LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try { bll.XuatExcel(dgvThietBi); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}