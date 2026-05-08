using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiThietBi : Form
    {
        ThietBiBLL bll = new ThietBiBLL();
        string action = ""; // Lưu trạng thái: "Them", "Sua", "Xoa"

        public frmQuanLiThietBi()
        {
            InitializeComponent();
        }

        private void frmQuanLiThietBi_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu mặc định cho ComboBox
            cmbLoaiTB.Items.AddRange(new string[] { "Điện tử", "Điện lạnh", "Âm thanh", "Mạng", "Nội thất", "Thí nghiệm", "An toàn", "Phụ kiện" });

            LoadData();
            TrangThaiBanDau();
        }

        private void TrangThaiBanDau()
        {
            action = "";
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtMaTB.Enabled = false;

            if (cmbLoaiTB.Items.Count > 0) cmbLoaiTB.SelectedIndex = 0;

            // Chỉnh trạng thái 5 nút
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvThietBi.Enabled = true;
        }

        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            dgvThietBi.Enabled = false; // Tạm khóa lưới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtMaTB.Enabled = true;
            txtMaTB.Focus();
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
            MessageBox.Show("Vui lòng nhấn LƯU để xác nhận xóa, hoặc HỦY để thôi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTB.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Thiết Bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThietBiDTO tb = new ThietBiDTO
            {
                MaTB = txtMaTB.Text,
                TenTB = txtTenTB.Text,
                LoaiTB = cmbLoaiTB.Text
            };

            bool kq = false;
            if (action == "Them") kq = bll.Them(tb);
            else if (action == "Sua") kq = bll.Sua(tb);
            else if (action == "Xoa") kq = bll.Xoa(txtMaTB.Text);

            if (kq)
            {
                MessageBox.Show("Thao tác thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                TrangThaiBanDau();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                txtMaTB.Text = dgvThietBi.Rows[r].Cells["Mã TB"].Value?.ToString();
                txtTenTB.Text = dgvThietBi.Rows[r].Cells["Tên Thiết Bị"].Value?.ToString();
                cmbLoaiTB.Text = dgvThietBi.Rows[r].Cells["Loại"].Value?.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void LoadData()
        {
            dgvThietBi.DataSource = bll.GetThietBi();
        }
    }
}