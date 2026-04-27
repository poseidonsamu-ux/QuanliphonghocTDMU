using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmBaoCaoSuCo : Form
    {
        BaoCaoSuCoBLL bll = new BaoCaoSuCoBLL();
        public frmBaoCaoSuCo() { InitializeComponent(); }

        private void frmBaoCaoSuCo_Load(object sender, EventArgs e)
        {
            LoadComboBoxPhong();
            if (frmDangNhap.Role == "Admin")
            {
                btnDaSua.Visible = true; lblSoLuongHong.Visible = false; numSoLuongHong.Visible = false;
                dgvThietBi.DataSource = bll.GetTatCaLoi(); // Hiện sớ táo quân đồ hư toàn trường
            }
            else
            {
                btnDaSua.Visible = false; lblSoLuongHong.Visible = true; numSoLuongHong.Visible = true;
                LoadThietBiTrongPhong();
            }
        }

        private void LoadComboBoxPhong() { cmbPhong.DataSource = bll.GetPhong(); cmbPhong.DisplayMember = "TenPhong"; cmbPhong.ValueMember = "MaPhong"; }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e) => LoadThietBiTrongPhong();

        private void LoadThietBiTrongPhong()
        {
            if (cmbPhong.SelectedValue != null && !(cmbPhong.SelectedValue is DataRowView))
                dgvThietBi.DataSource = bll.GetThietBiByPhong(cmbPhong.SelectedValue.ToString());
        }

        private void dgvThietBi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow != null && dgvThietBi.CurrentRow.Cells["Số Lượng"].Value != null)
                numSoLuongHong.Maximum = Convert.ToInt32(dgvThietBi.CurrentRow.Cells["Số Lượng"].Value);
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow == null) return;
            // SỬA LỖI CS1503: Dùng Columns.Contains thay vì Cells.Contains
            string maP = dgvThietBi.Columns.Contains("Mã Phòng") ? dgvThietBi.CurrentRow.Cells["Mã Phòng"].Value.ToString() : cmbPhong.SelectedValue.ToString();
            string kq = bll.BaoHongThietBi(maP, dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString(), dgvThietBi.CurrentRow.Cells["Tình Trạng"].Value.ToString(), (int)numSoLuongHong.Value);
            if (kq == "Thành công") { MessageBox.Show("Đã báo hỏng!"); LoadThietBiTrongPhong(); }
        }

        private void btnDaSua_Click(object sender, EventArgs e)
        {
            if (dgvThietBi.CurrentRow == null) return;
            // SỬA LỖI CS1503
            string maP = dgvThietBi.Columns.Contains("Mã Phòng") ? dgvThietBi.CurrentRow.Cells["Mã Phòng"].Value.ToString() : cmbPhong.SelectedValue.ToString();
            if (bll.SuaXongThietBi(maP, dgvThietBi.CurrentRow.Cells["Mã TB"].Value.ToString()))
            {
                MessageBox.Show("Sửa xong!");
                if (frmDangNhap.Role == "Admin") dgvThietBi.DataSource = bll.GetTatCaLoi(); else LoadThietBiTrongPhong();
            }
        }
    }
}