using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiPhongHoc : Form
    {
        PhongHocBLL bll = new PhongHocBLL();
        string action = ""; // Lưu trạng thái: "Them", "Sua", "Xoa"

        public frmQuanLiPhongHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLiPhongHoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxToaNha();

            // Nạp dữ liệu cứng cho 2 ComboBox nếu chưa có
            cmbLoaiPhong.Items.AddRange(new string[] { "Phòng thường", "Phòng máy", "Phòng thí nghiệm", "Giảng đường", "Hội trường" });
            cmbTrangThai.Items.AddRange(new string[] { "Sẵn sàng", "Đang bảo trì", "Không sử dụng" });

            LoadDanhSachPhongHoc();
            TrangThaiBanDau();
        }

        // TẤT CẢ NÚT ĐỀU HIỂN THỊ, CHỈ LÀM MỜ NÚT LƯU/HỦY BAN ĐẦU
        private void TrangThaiBanDau()
        {
            action = "";
            txtMaPhong.Clear(); txtTenPhong.Clear(); txtTang.Clear(); txtSucChua.Clear();
            txtMaPhong.Enabled = false;

            if (cmbLoaiPhong.Items.Count > 0) cmbLoaiPhong.SelectedIndex = 0;
            if (cmbTrangThai.Items.Count > 0) cmbTrangThai.SelectedIndex = 0;

            // Khóa/Mở nút
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            dgvPhongHoc.Enabled = true;
        }

        // BẤM THÊM/SỬA/XÓA SẼ LÀM MỜ TỤI NÓ, MỞ SÁNG NÚT LƯU/HỦY
        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            dgvPhongHoc.Enabled = false; // Khóa lưới để tập trung nhập liệu
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaPhong.Clear(); txtTenPhong.Clear(); txtTang.Clear(); txtSucChua.Clear();
            txtMaPhong.Enabled = true;
            txtMaPhong.Focus();
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
            MessageBox.Show("Vui lòng nhấn LƯU để xác nhận xóa, hoặc HỦY để thôi!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng!"); return;
            }

            PhongHocDTO ph = new PhongHocDTO
            {
                MaPhong = txtMaPhong.Text,
                MaToaNha = cmbToaNha.SelectedValue.ToString(),
                TenPhong = txtTenPhong.Text,
                Tang = txtTang.Text,
                LoaiPhong = cmbLoaiPhong.Text,
                SucChua = string.IsNullOrEmpty(txtSucChua.Text) ? 40 : int.Parse(txtSucChua.Text),
                TrangThai = cmbTrangThai.Text
            };

            bool kq = false;
            if (action == "Them") kq = bll.Them(ph);
            else if (action == "Sua") kq = bll.Sua(ph);
            else if (action == "Xoa") kq = bll.Xoa(txtMaPhong.Text);

            if (kq)
            {
                MessageBox.Show("Thao tác thành công!");
                LoadDanhSachPhongHoc();
                TrangThaiBanDau();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiBanDau();
        }

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

                // Bấm vào lưới thì mở sáng nút Sửa và Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void LoadComboBoxToaNha()
        {
            cmbToaNha.DataSource = bll.GetToaNha();
            cmbToaNha.DisplayMember = "TenKhu";
            cmbToaNha.ValueMember = "MaToaNha";
        }

        private void LoadDanhSachPhongHoc()
        {
            dgvPhongHoc.DataSource = bll.GetPhongHoc();
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            // Logic nhập Excel sẽ được xử lý sau
            MessageBox.Show("Chức năng Nhập dữ liệu từ Excel đang được cập nhật!");
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Logic xuất Excel sẽ được xử lý sau
            MessageBox.Show("Chức năng Xuất dữ liệu ra Excel đang được cập nhật!");
        }

        private void btnTaiMau_Click(object sender, EventArgs e)
        {

            // Logic: Mở SaveFileDialog -> Tạo file Excel trắng -> Ghi Header cột vào dòng 1
            MessageBox.Show("Tính năng đang được xây dựng!");
        }
    }
}