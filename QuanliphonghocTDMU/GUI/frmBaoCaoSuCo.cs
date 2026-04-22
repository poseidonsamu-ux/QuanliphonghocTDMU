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

            // Kiểm tra quyền từ form Đăng nhập (vẫn giữ static Role của bạn)
            if (frmDangNhap.Role == "GiangVien")
            {
                btnDaSua.Visible = false;
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

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null)
            {
                string maTB = dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString();
                string maPhong = cmbPhong.SelectedValue.ToString();
                string tinhTrang = dgvThietBi.CurrentRow.Cells["Tình Trạng"].Value.ToString();

                string ketQua = bll.BaoHongThietBi(maPhong, maTB, tinhTrang);

                if (ketQua == "Thành công")
                {
                    MessageBox.Show("Đã ghi nhận sự cố thiết bị. Ban quản lý sẽ xử lý sớm!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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