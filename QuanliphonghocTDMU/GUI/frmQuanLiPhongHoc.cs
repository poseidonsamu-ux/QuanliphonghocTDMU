using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiPhongHoc : Form
    {
        PhongHocBLL bll = new PhongHocBLL();
        string action = "";

        public frmQuanLiPhongHoc() { InitializeComponent(); }

        private void frmQuanLiPhongHoc_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBoxToaNha();
                cmbLoaiPhong.Items.AddRange(new string[] { "Phòng thường", "Phòng máy", "Phòng thí nghiệm", "Giảng đường", "Hội trường" });
                cmbTrangThai.Items.AddRange(new string[] { "Sẵn sàng", "Đang bảo trì", "Không sử dụng" });
                LoadDanhSachPhongHoc();
                TrangThaiBanDau();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi khởi tạo: " + ex.Message); }
        }

        // 1. Hàm bổ trợ giao diện
        private void LoadDanhSachPhongHoc() { dgvPhongHoc.DataSource = bll.GetPhongHoc(); }

        private void LoadComboBoxToaNha()
        {
            cmbToaNha.DataSource = bll.GetToaNha();
            cmbToaNha.DisplayMember = "TenKhu";
            cmbToaNha.ValueMember = "MaToaNha";
        }

        private void TrangThaiBanDau()
        {
            action = "";
            txtMaPhong.Clear(); txtTenPhong.Clear(); txtTang.Clear(); txtSucChua.Clear();
            txtMaPhong.Enabled = false;
            btnThem.Enabled = true; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = false; btnHuy.Enabled = false;
            dgvPhongHoc.Enabled = true;
        }

        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false; btnSua.Enabled = false; btnXoa.Enabled = false;
            btnLuu.Enabled = true; btnHuy.Enabled = true;
            dgvPhongHoc.Enabled = false;
        }

        // 2. Nghiệp vụ CRUD
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaPhong.Clear(); txtMaPhong.Enabled = true; txtMaPhong.Focus();
            BatCheDoThaoTac();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            action = "Sua";
            BatCheDoThaoTac();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            action = "Xoa";
            BatCheDoThaoTac();
            MessageBox.Show("Nhấn LƯU để xác nhận XÓA!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaPhong.Text)) { MessageBox.Show("Vui lòng nhập Mã Phòng!"); return; }

                PhongHocDTO ph = new PhongHocDTO
                {
                    MaPhong = txtMaPhong.Text.Trim(),
                    MaToaNha = cmbToaNha.SelectedValue.ToString(),
                    TenPhong = txtTenPhong.Text.Trim(),
                    Tang = txtTang.Text.Trim(),
                    LoaiPhong = cmbLoaiPhong.Text,
                    SucChua = int.Parse(string.IsNullOrEmpty(txtSucChua.Text) ? "40" : txtSucChua.Text),
                    TrangThai = cmbTrangThai.Text
                };

                bool kq = false;
                if (action == "Them") kq = bll.Them(ph);
                else if (action == "Sua") kq = bll.Sua(ph);
                else if (action == "Xoa") kq = bll.Xoa(txtMaPhong.Text);

                if (kq)
                {
                    MessageBox.Show("Thành công!");
                    LoadDanhSachPhongHoc();
                    TrangThaiBanDau();
                }
                else
                {
                    MessageBox.Show("Thất bại! Vui lòng kiểm tra lại dữ liệu.");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thực hiện: " + ex.Message); }
        }

        private void btnHuy_Click(object sender, EventArgs e) { TrangThaiBanDau(); }

        private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                txtMaPhong.Text = dgvPhongHoc.Rows[r].Cells["Mã Phòng"].Value?.ToString();
                cmbToaNha.Text = dgvPhongHoc.Rows[r].Cells["Tòa Nhà"].Value?.ToString();
                txtTenPhong.Text = dgvPhongHoc.Rows[r].Cells["Tên Phòng"].Value?.ToString();
                txtTang.Text = dgvPhongHoc.Rows[r].Cells["Tầng"].Value?.ToString();
                cmbLoaiPhong.Text = dgvPhongHoc.Rows[r].Cells["Loại Phòng"].Value?.ToString();
                txtSucChua.Text = dgvPhongHoc.Rows[r].Cells["Sức Chứa"].Value?.ToString();
                cmbTrangThai.Text = dgvPhongHoc.Rows[r].Cells["Trạng Thái"].Value?.ToString();
                btnSua.Enabled = true; btnXoa.Enabled = true;
            }
        }

        // 3. Xử lý Excel
        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Mau_PhongHoc.xlsx" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bll.TaiMau(sfd.FileName);
                    MessageBox.Show("Đã tải file mẫu!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx;*.xls" };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int sl = bll.NhapExcel(ofd.FileName);
                    MessageBox.Show($"Thành công: {sl} dòng.");
                    LoadDanhSachPhongHoc();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try { bll.XuatExcel(dgvPhongHoc); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}