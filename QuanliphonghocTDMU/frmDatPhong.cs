using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDatPhong : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox Ca học
            cmbCaHoc.Items.Add("1"); // Ca Sáng
            cmbCaHoc.Items.Add("2"); // Ca Chiều
            cmbCaHoc.Items.Add("3"); // Ca Tối
            cmbCaHoc.SelectedIndex = 0;

            // PHÂN QUYỀN THÔNG MINH
            // Nếu là Admin, cho phép chọn Giảng viên để đặt dùm.
            if (frmDangNhap.Role == "Admin")
            {
                cmbGiangVien.Visible = true;
                lblGiangVien.Visible = true;
                LoadGiangVien();
            }
            else
            {
                // Nếu là Giảng viên thì tự ẩn cái cbb đi, hệ thống ngầm hiểu là họ tự đặt
                cmbGiangVien.Visible = false;
                lblGiangVien.Visible = false;
            }
        }

        private void LoadGiangVien()
        {
            string sql = "SELECT MaGV, HoTen FROM GiangVien";
            cmbGiangVien.DataSource = kn.ExecuteQuery(sql);
            cmbGiangVien.DisplayMember = "HoTen";
            cmbGiangVien.ValueMember = "MaGV";
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {
            string ngayDat = dtpNgayDat.Value.ToString("yyyy-MM-dd");
            string caHoc = cmbCaHoc.SelectedItem.ToString();

            // THUẬT TOÁN TÌM PHÒNG TRỐNG: Lấy phòng KHÔNG CÓ trong bảng Lịch Đặt vào ngày đó, ca đó
            string sql = string.Format(@"
                SELECT MaPhong AS [Mã Phòng], TenPhong AS [Tên Phòng], LoaiPhong AS [Loại], SucChua AS [Sức chứa] 
                FROM PhongHoc 
                WHERE TrangThai = N'Sẵn sàng' 
                AND MaPhong NOT IN (
                    SELECT MaPhong FROM LichDatPhong 
                    WHERE NgayDat = '{0}' AND CaHoc = {1} AND TrangThaiDuyet != N'Từ chối'
                )", ngayDat, caHoc);

            DataTable dt = kn.ExecuteQuery(sql);
            dgvPhongTrong.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Rất tiếc! Đã hết phòng trống vào thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPhongTrong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtPhongChon.Text = dgvPhongTrong.Rows[e.RowIndex].Cells["Mã Phòng"].Value.ToString();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhongChon.Text))
            {
                MessageBox.Show("Vui lòng click chọn một phòng từ danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtMucDich.Text))
            {
                MessageBox.Show("Vui lòng nhập mục đích sử dụng (vd: Dạy bù, Báo cáo đồ án...)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã GV: Admin đặt dùm thì lấy từ cbb, Giảng viên thì lấy từ Form Đăng nhập truyền sang
            string maGV = frmDangNhap.Role == "Admin" ? cmbGiangVien.SelectedValue.ToString() : frmDangNhap.MaGV;
            string ngayDat = dtpNgayDat.Value.ToString("yyyy-MM-dd");
            string caHoc = cmbCaHoc.SelectedItem.ToString();

            // Set tiết bắt đầu / kết thúc tự động dựa theo Ca học
            int tietBD = (caHoc == "1") ? 1 : (caHoc == "2" ? 6 : 11);
            int tietKT = (caHoc == "1") ? 5 : (caHoc == "2" ? 10 : 15);

            // Trạng thái: Nếu là Admin thì duyệt ngay lập tức, GV thì phải chờ Phòng đào tạo duyệt
            string trangThai = frmDangNhap.Role == "Admin" ? "Đã duyệt" : "Chờ duyệt";

            string sql = string.Format(@"INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) 
                            VALUES ('{0}', '{1}', '{2}', {3}, {4}, {5}, N'{6}', N'{7}')",
                            txtPhongChon.Text, maGV, ngayDat, caHoc, tietBD, tietKT, txtMucDich.Text, trangThai);

            if (kn.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Tuyệt vời! Đăng ký mượn phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMucDich.Clear();
                txtPhongChon.Clear();
                btnTimPhong_Click(sender, e); // Load lại danh sách, phòng vừa đặt sẽ tự động biến mất!
            }
        }
    }
}