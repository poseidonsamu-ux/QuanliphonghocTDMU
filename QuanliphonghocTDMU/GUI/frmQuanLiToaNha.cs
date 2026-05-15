using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiToaNha : Form
    {
        // 1. Khai báo nghiệp vụ
        ToaNhaBLL bll = new ToaNhaBLL();
        string action = "";

        public frmQuanLiToaNha()
        {
            InitializeComponent();
        }

        private void frmQuanLiToaNha_Load(object sender, EventArgs e)
        {
            LoadDanhSachToaNha();
            TrangThaiBanDau();
        }

        // 2. Các hàm hỗ trợ giao diện
        private void LoadDanhSachToaNha()
        {
            dgvToaNha.DataSource = bll.LayToaNha();
        }

        private void TrangThaiBanDau()
        {
            action = "";
            txtMaToaNha.Clear(); txtSoTang.Clear(); txtGhiChu.Clear();
            txtMaToaNha.Enabled = false; txtSoTang.Enabled = false; txtGhiChu.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvToaNha.Enabled = true;
        }

        private void BatCheDoThaoTac()
        {
            txtSoTang.Enabled = true;
            txtGhiChu.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            dgvToaNha.Enabled = false;
        }

        private ToaNhaDTO LayDuLieuTuForm()
        {
            return new ToaNhaDTO
            {
                MaToaNha = txtMaToaNha.Text.Trim(),
                TenKhu = "Khu " + txtMaToaNha.Text.Trim(),
                SoTang = string.IsNullOrEmpty(txtSoTang.Text) ? 1 : int.Parse(txtSoTang.Text),
                GhiChu = txtGhiChu.Text.Trim()
            };
        }

        // 3. Xử lý Thêm, Sửa, Xóa
        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaToaNha.Clear(); txtSoTang.Clear(); txtGhiChu.Clear();
            txtMaToaNha.Enabled = true;
            txtMaToaNha.Focus();
            BatCheDoThaoTac();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            action = "Sua";
            txtMaToaNha.Enabled = false;
            BatCheDoThaoTac();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            action = "Xoa";
            BatCheDoThaoTac();
            MessageBox.Show("Vui lòng nhấn LƯU để xác nhận xóa!", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text) && action != "Xoa")
            {
                MessageBox.Show("Vui lòng nhập Mã Tòa Nhà!");
                return;
            }

            ToaNhaDTO tn = LayDuLieuTuForm();
            bool kq = false;

            // Xử lý theo từng hành động
            if (action == "Them") kq = bll.Them(tn);
            else if (action == "Sua") kq = bll.Sua(tn);
            else if (action == "Xoa")
            {
                if (MessageBox.Show("Xác nhận xóa Tòa Nhà và toàn bộ phòng học bên trong?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    kq = bll.Xoa(txtMaToaNha.Text);
                else { TrangThaiBanDau(); return; }
            }

            if (kq)
            {
                MessageBox.Show("Thao tác thành công!");
                LoadDanhSachToaNha();
                TrangThaiBanDau();
            }
            else MessageBox.Show("Thao tác thất bại!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        // 4. Đổ dữ liệu từ bảng lên textbox
        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                // Lấy đúng tên cột alias từ DAL
                txtMaToaNha.Text = dgvToaNha.Rows[r].Cells["Mã Tòa Nhà"].Value?.ToString();
                txtSoTang.Text = dgvToaNha.Rows[r].Cells["Số Tầng"].Value?.ToString();
                txtGhiChu.Text = dgvToaNha.Rows[r].Cells["Ghi Chú"].Value?.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // 5. Xử lý các sự kiện Excel (Đã fix lỗi Filter)
        private void btnTaiMau_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                // Fix Filter
                Filter = "Excel Workbook (*.xlsx)|*.xlsx",
                FileName = "Mau_Nhap_ToaNha.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bll.TaiMau(sfd.FileName);
                MessageBox.Show("Đã tải file mẫu thành công!");
            }
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls",
                Title = "Chọn file Excel nhập dữ liệu"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int thanhCong = bll.NhapExcel(ofd.FileName);
                    MessageBox.Show($"Đã nhập thành công {thanhCong} dòng!");
                    LoadDanhSachToaNha();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            bll.XuatExcel(dgvToaNha);
        }
    }
}