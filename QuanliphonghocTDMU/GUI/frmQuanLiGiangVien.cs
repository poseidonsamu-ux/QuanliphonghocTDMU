using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiGiangVien : Form
    {
        GiangVienBLL bll = new GiangVienBLL();
        string action = ""; // Lưu trạng thái: "Them", "Sua", "Xoa"

        public frmQuanLiGiangVien() { InitializeComponent(); }

        private void frmQuanLiGiangVien_Load(object sender, EventArgs e)
        {
            TaiDuLieuKhoa();
            TaiDanhSach();
            TrangThaiBanDau();
        }

        // TẤT CẢ NÚT ĐỀU HIỂN THỊ, CHỈ LÀM MỜ (Enabled = false)
        private void TrangThaiBanDau()
        {
            action = "";
            txtMaGV.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtEmail.Clear();
            txtMaGV.Enabled = false;

            // Nút nào được sáng, nút nào bị xám
            btnThem.Enabled = true;  // Sáng
            btnSua.Enabled = false;  // Xám
            btnXoa.Enabled = false;  // Xám
            btnLuu.Enabled = false;  // Xám
            btnHuy.Enabled = false;  // Xám

            dgvGiangVien.Enabled = true;
        }

        // BẤM THÊM/SỬA/XÓA SẼ LÀM MỜ TỤI NÓ, SÁNG NÚT LƯU/HỦY
        private void BatCheDoThaoTac()
        {
            btnThem.Enabled = false; // Xám
            btnSua.Enabled = false;  // Xám
            btnXoa.Enabled = false;  // Xám

            btnLuu.Enabled = true;   // Sáng
            btnHuy.Enabled = true;   // Sáng

            dgvGiangVien.Enabled = false; // Khóa lưới
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            action = "Them";
            txtMaGV.Clear(); txtHoTen.Clear(); txtSDT.Clear(); txtEmail.Clear();
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
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
            if (string.IsNullOrEmpty(txtMaGV.Text)) return;

            GiangVienDTO gv = new GiangVienDTO
            {
                MaGV = txtMaGV.Text,
                HoTen = txtHoTen.Text,
                MaKhoa = cmbKhoa.SelectedValue.ToString(),
                SoDienThoai = txtSDT.Text,
                Email = txtEmail.Text
            };

            bool kq = false;
            if (action == "Them") kq = bll.Them(gv);
            else if (action == "Sua") kq = bll.Sua(gv);
            else if (action == "Xoa") kq = bll.Xoa(txtMaGV.Text);

            if (kq)
            {
                MessageBox.Show("Thành công!");
                TaiDanhSach();
                TrangThaiBanDau();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) { TrangThaiBanDau(); }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangChon = e.RowIndex;
            if (hangChon >= 0 && action == "")
            {
                txtMaGV.Text = dgvGiangVien.Rows[hangChon].Cells["Mã GV"].Value?.ToString();
                txtHoTen.Text = dgvGiangVien.Rows[hangChon].Cells["Họ Tên"].Value?.ToString();
                cmbKhoa.Text = dgvGiangVien.Rows[hangChon].Cells["Khoa/Viện"].Value?.ToString();
                txtSDT.Text = dgvGiangVien.Rows[hangChon].Cells["SĐT"].Value?.ToString();
                txtEmail.Text = dgvGiangVien.Rows[hangChon].Cells["Email"].Value?.ToString();

                // Bấm vào lưới thì mở sáng nút Sửa và Xóa
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void TaiDuLieuKhoa()
        {
            cmbKhoa.DataSource = bll.LayKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void TaiDanhSach() { dgvGiangVien.DataSource = bll.LayGiangVien(); }

        // Sự kiện xuất Excel, code xử lí vào 2 nút này đang được chuẩn bị, nên tạm thời chỉ hiện thông báo

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tính năng xuất Excel đang được chuẩn bị!");
        }

        // Sự kiện nhập Excel
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Tính năng nhập dữ liệu từ Excel đang được chuẩn bị!");
        }

        private void btnTaiMau_Click(object sender, EventArgs e)
        {

            // Logic: Mở SaveFileDialog -> Tạo file Excel trắng -> Ghi Header cột vào dòng 1
            MessageBox.Show("Tính năng đang được xây dựng!");
        }
    }
}