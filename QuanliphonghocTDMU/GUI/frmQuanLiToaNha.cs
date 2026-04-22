using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiToaNha : Form
    {
        ToaNhaBLL bll = new ToaNhaBLL();

        public frmQuanLiToaNha()
        {
            InitializeComponent();
        }

        private void frmQuanLiToaNha_Load(object sender, EventArgs e)
        {
            LoadDanhSachToaNha();
        }

        private void LoadDanhSachToaNha()
        {
            dgvToaNha.DataSource = bll.LayToaNha();
        }

        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaToaNha.Text = dgvToaNha.Rows[r].Cells["Mã Tòa Nhà"].Value?.ToString();
                txtSoTang.Text = dgvToaNha.Rows[r].Cells["Số Tầng"].Value?.ToString();
                txtGhiChu.Text = dgvToaNha.Rows[r].Cells["Ghi Chú"].Value?.ToString();

                txtMaToaNha.Enabled = false;
            }
        }

        // Đóng gói dữ liệu vào DTO trước khi gửi xuống BLL
        private ToaNhaDTO LayDuLieuTuForm()
        {
            return new ToaNhaDTO
            {
                MaToaNha = txtMaToaNha.Text,
                TenKhu = "Khu " + txtMaToaNha.Text, // Tự động sinh Tên Khu
                SoTang = string.IsNullOrEmpty(txtSoTang.Text) ? 1 : int.Parse(txtSoTang.Text), // Mặc định là 1 nếu bỏ trống
                GhiChu = txtGhiChu.Text
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Tòa Nhà!");
                return;
            }

            ToaNhaDTO tn = LayDuLieuTuForm();

            if (bll.Them(tn))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDanhSachToaNha();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng chọn Tòa Nhà cần sửa dưới bảng!");
                return;
            }

            ToaNhaDTO tn = LayDuLieuTuForm();

            if (bll.Sua(tn))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachToaNha();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng chọn Tòa Nhà cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa Tòa Nhà này không? Toàn bộ phòng học thuộc tòa nhà này sẽ biến mất!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bll.Xoa(txtMaToaNha.Text))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachToaNha();
                    btnLamMoi_Click(sender, e);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaToaNha.Clear();
            txtSoTang.Clear();
            txtGhiChu.Clear();
            txtMaToaNha.Enabled = true;
            txtMaToaNha.Focus();
        }
    }
}