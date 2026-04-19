using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiGiangVien : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmQuanLiGiangVien()
        {
            InitializeComponent();
        }

        private void frmQuanLiGiangVien_Load(object sender, EventArgs e)
        {
            LoadComboBoxKhoa();
            LoadData();
        }

        private void LoadComboBoxKhoa()
        {
            string sql = "SELECT MaKhoa, TenKhoa FROM KhoaVien";
            DataTable dt = kn.ExecuteQuery(sql);
            cmbKhoa.DataSource = dt;
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void LoadData()
        {
            string sql = @"SELECT g.MaGV AS [Mã GV], g.HoTen AS [Họ Tên], 
                                  k.TenKhoa AS [Khoa/Viện], g.SoDienThoai AS [SĐT], g.Email AS [Email]
                           FROM GiangVien g
                           JOIN KhoaVien k ON g.MaKhoa = k.MaKhoa";
            dgvGiangVien.DataSource = kn.ExecuteQuery(sql);
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaGV.Text = dgvGiangVien.Rows[r].Cells["Mã GV"].Value?.ToString();
                txtHoTen.Text = dgvGiangVien.Rows[r].Cells["Họ Tên"].Value?.ToString();
                cmbKhoa.Text = dgvGiangVien.Rows[r].Cells["Khoa/Viện"].Value?.ToString();
                txtSDT.Text = dgvGiangVien.Rows[r].Cells["SĐT"].Value?.ToString();
                txtEmail.Text = dgvGiangVien.Rows[r].Cells["Email"].Value?.ToString();
                txtMaGV.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGV.Text)) return;
            string maKhoa = cmbKhoa.SelectedValue.ToString();
            string sql = string.Format("INSERT INTO GiangVien VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}')",
                txtMaGV.Text, txtHoTen.Text, maKhoa, txtSDT.Text, txtEmail.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKhoa = cmbKhoa.SelectedValue.ToString();
            string sql = string.Format("UPDATE GiangVien SET HoTen = N'{0}', MaKhoa = '{1}', SoDienThoai = '{2}', Email = '{3}' WHERE MaGV = '{4}'",
                txtHoTen.Text, maKhoa, txtSDT.Text, txtEmail.Text, txtMaGV.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("DELETE FROM GiangVien WHERE MaGV = '{0}'", txtMaGV.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
        }
    }
}