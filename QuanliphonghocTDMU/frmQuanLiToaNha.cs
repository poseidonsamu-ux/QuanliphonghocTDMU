using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiToaNha : Form
    {
        // Gọi file kết nối CSDL (Hãy chắc chắn bạn đã tạo file KetNoiCSDL.cs như bài trước)
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmQuanLiToaNha()
        {
            InitializeComponent();
        }

        // Sự kiện: Chạy ngay khi mở form
        private void frmQuanLiToaNha_Load(object sender, EventArgs e)
        {
            LoadDanhSachToaNha();
        }

        // Hàm: Lấy danh sách đổ lên DataGridView
        private void LoadDanhSachToaNha()
        {
            string sql = "SELECT MaToaNha AS [Mã Tòa Nhà], TenKhu AS [Tên Khu], SoTang AS [Số Tầng], GhiChu AS [Ghi Chú] FROM ToaNha";
            dgvToaNha.DataSource = kn.ExecuteQuery(sql);
        }

        // Sự kiện: Bấm vào dòng nào trên bảng thì hiện dữ liệu lên TextBox
        private void dgvToaNha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaToaNha.Text = dgvToaNha.Rows[r].Cells["Mã Tòa Nhà"].Value.ToString();
                txtSoTang.Text = dgvToaNha.Rows[r].Cells["Số Tầng"].Value.ToString();
                txtGhiChu.Text = dgvToaNha.Rows[r].Cells["Ghi Chú"].Value.ToString();

                txtMaToaNha.Enabled = false; // Khóa ô Mã Tòa Nhà, không cho sửa Khóa chính
            }
        }

        // NÚT THÊM
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Tòa Nhà!");
                return;
            }

            // Tự động sinh Tên Khu dựa vào Mã (Ví dụ: Nhập A1 -> Tên Khu A1)
            string tenKhu = "Khu " + txtMaToaNha.Text;
            string soTang = string.IsNullOrEmpty(txtSoTang.Text) ? "1" : txtSoTang.Text;

            string sqlThem = string.Format("INSERT INTO ToaNha(MaToaNha, TenKhu, SoTang, GhiChu) VALUES ('{0}', N'{1}', {2}, N'{3}')",
                                            txtMaToaNha.Text, tenKhu, soTang, txtGhiChu.Text);

            if (kn.ExecuteNonQuery(sqlThem))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDanhSachToaNha();
                btnLamMoi_Click(sender, e); // Xóa trắng ô nhập
            }
        }

        // NÚT SỬA
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng chọn Tòa Nhà cần sửa dưới bảng!");
                return;
            }

            string soTang = string.IsNullOrEmpty(txtSoTang.Text) ? "1" : txtSoTang.Text;

            string sqlSua = string.Format("UPDATE ToaNha SET SoTang = {0}, GhiChu = N'{1}' WHERE MaToaNha = '{2}'",
                                            soTang, txtGhiChu.Text, txtMaToaNha.Text);

            if (kn.ExecuteNonQuery(sqlSua))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachToaNha();
                btnLamMoi_Click(sender, e);
            }
        }

        // NÚT XÓA
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaNha.Text))
            {
                MessageBox.Show("Vui lòng chọn Tòa Nhà cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa Tòa Nhà này không? Toàn bộ phòng học thuộc tòa nhà này sẽ biến mất!", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string sqlXoa = string.Format("DELETE FROM ToaNha WHERE MaToaNha = '{0}'", txtMaToaNha.Text);

                if (kn.ExecuteNonQuery(sqlXoa))
                {
                    MessageBox.Show("Xóa thành công!");
                    LoadDanhSachToaNha();
                    btnLamMoi_Click(sender, e);
                }
            }
        }

        // NÚT LÀM MỚI (Xóa trắng Textbox)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaToaNha.Clear();
            txtSoTang.Clear();
            txtGhiChu.Clear();
            txtMaToaNha.Enabled = true; // Mở khóa lại ô Mã Tòa Nhà để nhập mới
            txtMaToaNha.Focus();
        }
    }
}