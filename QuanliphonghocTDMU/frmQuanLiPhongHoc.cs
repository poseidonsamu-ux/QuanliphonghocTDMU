using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiPhongHoc : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmQuanLiPhongHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLiPhongHoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxToaNha();
            LoadDanhSachPhongHoc();

            // Set giá trị mặc định cho các ComboBox khi vừa mở form
            if (cmbLoaiPhong.Items.Count > 0) cmbLoaiPhong.SelectedIndex = 0;
            if (cmbTrangThai.Items.Count > 0) cmbTrangThai.SelectedIndex = 0;
        }

        // Lấy danh sách Tòa Nhà từ DB đổ vào ComboBox
        private void LoadComboBoxToaNha()
        {
            string sql = "SELECT MaToaNha, TenKhu FROM ToaNha";
            DataTable dtToaNha = kn.ExecuteQuery(sql);

            cmbToaNha.DataSource = dtToaNha;
            cmbToaNha.DisplayMember = "TenKhu"; // Chữ hiện lên cho người dùng xem
            cmbToaNha.ValueMember = "MaToaNha"; // Giá trị ngầm bên dưới (Mã để lưu vào SQL)
        }

        // Đổ dữ liệu lên DataGridView (Dùng JOIN để hiện Tên Khu thay vì Mã Toà Nhà cho đẹp)
        private void LoadDanhSachPhongHoc()
        {
            string sql = @"SELECT p.MaPhong AS [Mã Phòng], t.TenKhu AS [Tòa Nhà], 
                                  p.TenPhong AS [Tên Phòng], p.Tang AS [Tầng], 
                                  p.LoaiPhong AS [Loại Phòng], p.SucChua AS [Sức Chứa], p.TrangThai AS [Trạng Thái]
                           FROM PhongHoc p
                           JOIN ToaNha t ON p.MaToaNha = t.MaToaNha";
            dgvPhongHoc.DataSource = kn.ExecuteQuery(sql);
        }

        // Click vào DataGridView -> Hiện dữ liệu lên các ô TextBox/ComboBox
        private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaPhong.Text = dgvPhongHoc.Rows[r].Cells["Mã Phòng"].Value.ToString();
                cmbToaNha.Text = dgvPhongHoc.Rows[r].Cells["Tòa Nhà"].Value.ToString();
                txtTenPhong.Text = dgvPhongHoc.Rows[r].Cells["Tên Phòng"].Value.ToString();
                txtTang.Text = dgvPhongHoc.Rows[r].Cells["Tầng"].Value.ToString();
                cmbLoaiPhong.Text = dgvPhongHoc.Rows[r].Cells["Loại Phòng"].Value.ToString();
                txtSucChua.Text = dgvPhongHoc.Rows[r].Cells["Sức Chứa"].Value.ToString();
                cmbTrangThai.Text = dgvPhongHoc.Rows[r].Cells["Trạng Thái"].Value.ToString();

                txtMaPhong.Enabled = false; // Không cho sửa khóa chính
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng!"); return;
            }

            string maToaNha = cmbToaNha.SelectedValue.ToString(); // Lấy mã chìm bên dưới
            string sucChua = string.IsNullOrEmpty(txtSucChua.Text) ? "40" : txtSucChua.Text;

            string sqlThem = string.Format(
                "INSERT INTO PhongHoc(MaPhong, MaToaNha, TenPhong, Tang, LoaiPhong, SucChua, TrangThai) " +
                "VALUES ('{0}', '{1}', N'{2}', N'{3}', N'{4}', {5}, N'{6}')",
                txtMaPhong.Text, maToaNha, txtTenPhong.Text, txtTang.Text,
                cmbLoaiPhong.Text, sucChua, cmbTrangThai.Text);

            if (kn.ExecuteNonQuery(sqlThem))
            {
                MessageBox.Show("Thêm phòng học thành công!");
                LoadDanhSachPhongHoc();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maToaNha = cmbToaNha.SelectedValue.ToString();
            string sucChua = string.IsNullOrEmpty(txtSucChua.Text) ? "40" : txtSucChua.Text;

            string sqlSua = string.Format(
                "UPDATE PhongHoc SET MaToaNha = '{0}', TenPhong = N'{1}', Tang = N'{2}', " +
                "LoaiPhong = N'{3}', SucChua = {4}, TrangThai = N'{5}' WHERE MaPhong = '{6}'",
                maToaNha, txtTenPhong.Text, txtTang.Text, cmbLoaiPhong.Text,
                sucChua, cmbTrangThai.Text, txtMaPhong.Text);

            if (kn.ExecuteNonQuery(sqlSua))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachPhongHoc();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlXoa = string.Format("DELETE FROM PhongHoc WHERE MaPhong = '{0}'", txtMaPhong.Text);
                if (kn.ExecuteNonQuery(sqlXoa))
                {
                    MessageBox.Show("Đã xóa phòng học!");
                    LoadDanhSachPhongHoc();
                    btnLamMoi_Click(sender, e);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtTang.Clear();
            txtSucChua.Clear();
            txtMaPhong.Enabled = true;
            txtMaPhong.Focus();
        }
    }
}