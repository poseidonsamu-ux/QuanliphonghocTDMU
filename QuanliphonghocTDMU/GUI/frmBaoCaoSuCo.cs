using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmBaoCaoSuCo : Form
    {
        BaoCaoSuCoBLL bll = new BaoCaoSuCoBLL();

        public frmBaoCaoSuCo()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSuCo_Load(object sender, EventArgs e)
        {
            LoadComboBoxPhong();

            string role = frmDangNhap.Role;
            // Ẩn hiện theo quyền
            if (role == "GiangVien" || role == "Giảng Viên" || role == "Giảng viên")
            {
                btnDaSua.Visible = false; // GV không được sửa
                lblSoLuongHong.Visible = true; // Hiện ô nhập số lượng cho GV
                numSoLuongHong.Visible = true;
            }
            else
            {
                btnDaSua.Visible = true; // Admin được ấn đã sửa xong
                lblSoLuongHong.Visible = false; // Ẩn chọn số lượng
                numSoLuongHong.Visible = false;
            }
        }

        private void LoadComboBoxPhong()
        {
            cmbPhong.DataSource = bll.GetPhong();
            cmbPhong.DisplayMember = "TenPhong";
            cmbPhong.ValueMember = "MaPhong";
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadThietBiTrongPhong();
        }

        private void LoadThietBiTrongPhong()
        {
            if (cmbPhong.SelectedValue != null && !(cmbPhong.SelectedValue is DataRowView))
            {
                dgvThietBi.DataSource = bll.GetThietBiByPhong(cmbPhong.SelectedValue.ToString());
            }
        }

        // Sự kiện này giúp giới hạn số lượng hư hỏng không vượt quá số lượng thực tế
        private void dgvThietBi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                int maxSoLuong = Convert.ToInt32(dgvThietBi.CurrentRow.Cells["Số Lượng"].Value);
                numSoLuongHong.Maximum = maxSoLuong > 0 ? maxSoLuong : 1;
                numSoLuongHong.Value = 1; // Mặc định mỗi lần bấm là 1
            }
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maTB = dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString();
                string maPhong = cmbPhong.SelectedValue.ToString();
                string tinhTrang = dgvThietBi.CurrentRow.Cells["Tình Trạng"].Value.ToString();

                // Lấy số lượng từ Form
                int soLuongHong = (int)numSoLuongHong.Value;

                // Truyền số lượng xuống BLL
                string ketQua = bll.BaoHongThietBi(maPhong, maTB, tinhTrang, soLuongHong);

                if (ketQua == "Thành công")
                {
                    MessageBox.Show($"Đã báo hỏng {soLuongHong} thiết bị. BQL sẽ xử lý sớm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThietBiTrongPhong();
                }
                else
                {
                    MessageBox.Show(ketQua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDaSua_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maTB = dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString();
                string maPhong = cmbPhong.SelectedValue.ToString();

                if (bll.SuaXongThietBi(maPhong, maTB))
                {
                    MessageBox.Show("Đã cập nhật trạng thái thiết bị thành: Bình thường!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadThietBiTrongPhong();
                }
            }
        }
    }
}