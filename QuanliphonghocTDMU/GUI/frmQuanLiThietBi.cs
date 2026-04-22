using QuanLiPhongHocTDMU.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiThietBi : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmQuanLiThietBi()
        {
            InitializeComponent();
        }

        private void frmQuanLiThietBi_Load(object sender, EventArgs e)
        {
            LoadData();
            if (cmbLoaiTB.Items.Count > 0)
            {
                cmbLoaiTB.SelectedIndex = 0;
            }
        }

        private void LoadData()
        {
            string sql = "SELECT MaTB AS [Mã TB], TenTB AS [Tên Thiết Bị], LoaiTB AS [Loại] FROM ThietBi";
            dgvThietBi.DataSource = kn.ExecuteQuery(sql);
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaTB.Text = dgvThietBi.Rows[r].Cells["Mã TB"].Value.ToString();
                txtTenTB.Text = dgvThietBi.Rows[r].Cells["Tên Thiết Bị"].Value.ToString();
                cmbLoaiTB.Text = dgvThietBi.Rows[r].Cells["Loại"].Value.ToString();
                txtMaTB.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTB.Text)) return;
            string sql = string.Format("INSERT INTO ThietBi VALUES ('{0}', N'{1}', N'{2}')", txtMaTB.Text, txtTenTB.Text, cmbLoaiTB.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = string.Format("UPDATE ThietBi SET TenTB = N'{0}', LoaiTB = N'{1}' WHERE MaTB = '{2}'", txtTenTB.Text, cmbLoaiTB.Text, txtMaTB.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("DELETE FROM ThietBi WHERE MaTB = '{0}'", txtMaTB.Text);
            if (kn.ExecuteNonQuery(sql))
            {
                LoadData();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaTB.Clear();
            txtTenTB.Clear();
            txtMaTB.Enabled = true;
            txtMaTB.Focus();
        }
    }
}