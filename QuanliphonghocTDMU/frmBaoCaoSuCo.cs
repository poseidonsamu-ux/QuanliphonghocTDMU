using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmBaoCaoSuCo : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmBaoCaoSuCo()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSuCo_Load(object sender, EventArgs e)
        {
            LoadComboBoxPhong();

            // Nếu là Giảng viên thì ẩn nút "Đã sửa xong" (chỉ Admin mới được bấm nút này)
            if (frmDangNhap.Role == "GiangVien")
            {
                btnDaSua.Visible = false;
            }
        }

        private void LoadComboBoxPhong()
        {
            string sql = "SELECT MaPhong, TenPhong FROM PhongHoc";
            cmbPhong.DataSource = kn.ExecuteQuery(sql);
            cmbPhong.DisplayMember = "TenPhong";
            cmbPhong.ValueMember = "MaPhong";
        }

        // Khi chọn phòng khác, danh sách thiết bị tự cập nhật theo
        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThietBiTrongPhong();
        }

        private void LoadThietBiTrongPhong()
        {
            if (cmbPhong.SelectedValue != null && cmbPhong.SelectedValue is DataRowView == false)
            {
                string maPhong = cmbPhong.SelectedValue.ToString();
                string sql = string.Format(@"
                    SELECT tb.MaTB AS [Mã TB], tb.TenTB AS [Tên Thiết Bị], 
                           tbp.SoLuong AS [Số Lượng], tbp.TinhTrang AS [Tình Trạng]
                    FROM TrangBiPhong tbp
                    JOIN ThietBi tb ON tbp.MaTB = tb.MaTB
                    WHERE tbp.MaPhong = '{0}'", maPhong);
                dgvThietBi.DataSource = kn.ExecuteQuery(sql);
            }
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maTB = dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString();
                string maPhong = cmbPhong.SelectedValue.ToString();
                string tinhTrangHienTai = dgvThietBi.CurrentRow.Cells["Tình Trạng"].Value.ToString();

                if (tinhTrangHienTai == "Hư hỏng")
                {
                    MessageBox.Show("Thiết bị này đã được báo hỏng trước đó rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string sql = string.Format("UPDATE TrangBiPhong SET TinhTrang = N'Hư hỏng' WHERE MaPhong = '{0}' AND MaTB = '{1}'", maPhong, maTB);
                if (kn.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Đã ghi nhận sự cố thiết bị. Ban quản lý sẽ xử lý sớm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThietBiTrongPhong(); // Tải lại danh sách
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị đang bị hỏng từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDaSua_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maTB = dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString();
                string maPhong = cmbPhong.SelectedValue.ToString();

                string sql = string.Format("UPDATE TrangBiPhong SET TinhTrang = N'Bình thường' WHERE MaPhong = '{0}' AND MaTB = '{1}'", maPhong, maTB);
                if (kn.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Đã cập nhật trạng thái thiết bị thành: Bình thường!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThietBiTrongPhong();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một thiết bị để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}