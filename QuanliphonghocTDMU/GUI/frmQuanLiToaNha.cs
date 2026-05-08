using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiToaNha : Form
    {
        ToaNhaBLL bll = new ToaNhaBLL();
        string action = ""; // Lưu trạng thái: "Them", "Sua", "Xoa"

        public frmQuanLiToaNha()
        {
            InitializeComponent();
        }

        private void frmQuanLiToaNha_Load(object sender, EventArgs e)
        {
            LoadDanhSachToaNha();
            TrangThaiBanDau();
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

        // TẤT CẢ NÚT ĐỀU HIỂN THỊ, CHỈ LÀM MỜ NÚT LƯU/HỦY BAN ĐẦU
        private void TrangThaiBanDau()
        {
            action = "";
            txtMaToaNha.Clear();
            txtSoTang.Clear();
            txtGhiChu.Clear();
            txtMaToaNha.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvToaNha.Enabled = true;
        }

        // BẤM THÊM/SỬA/XÓA SẼ LÀM MỜ TỤI NÓ, MỞ SÁNG NÚT LƯU/HỦY
        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            dgvToaNha.Enabled = false; // Khóa lưới
        }

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
            BatCheDoThaoTac();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            action = "Xoa";
            BatCheDoThaoTac();
            MessageBox.Show("Vui lòng nhấn LƯU để xác nhận xóa, hoặc HỦY để thôi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Tòa Nhà!");
                return;
            }

            ToaNhaDTO tn = LayDuLieuTuForm();
            bool kq = false;

            if (action == "Them") kq = bll.Them(tn);
            else if (action == "Sua") kq = bll.Sua(tn);
            else if (action == "Xoa")
            {
                if (MessageBox.Show("Xóa Tòa Nhà này thì toàn bộ Phòng Học bên trong sẽ bị xóa theo! Tiếp tục?", "Nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    kq = bll.Xoa(txtMaToaNha.Text);
                }
                else
                {
                    TrangThaiBanDau();
                    return;
                }
            }

            if (kq)
            {
                MessageBox.Show("Thao tác thành công!");
                LoadDanhSachToaNha();
                TrangThaiBanDau();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0 && action == "")
            {
                txtMaToaNha.Text = dgvToaNha.Rows[r].Cells["Mã Tòa Nhà"].Value?.ToString();
                txtSoTang.Text = dgvToaNha.Rows[r].Cells["Số Tầng"].Value?.ToString();
                txtGhiChu.Text = dgvToaNha.Rows[r].Cells["Ghi Chú"].Value?.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void LoadDanhSachToaNha()
        {
            dgvToaNha.DataSource = bll.LayToaNha();
        }
    }
}