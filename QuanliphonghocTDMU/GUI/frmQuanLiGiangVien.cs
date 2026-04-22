using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiGiangVien : Form
    {
        GiangVienBLL bll = new GiangVienBLL();

        public frmQuanLiGiangVien()
        {
            InitializeComponent();
        }

        private void frmQuanLiGiangVien_Load(object sender, EventArgs e)
        {
            TaiDuLieuKhoa();
            TaiDanhSach();
        }

        private void TaiDuLieuKhoa()
        {
            cmbKhoa.DataSource = bll.LayKhoa();
            cmbKhoa.DisplayMember = "TenKhoa";
            cmbKhoa.ValueMember = "MaKhoa";
        }

        private void TaiDanhSach()
        {
            dgvGiangVien.DataSource = bll.LayGiangVien();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int hangChon = e.RowIndex;
            if (hangChon >= 0)
            {
                txtMaGV.Text = dgvGiangVien.Rows[hangChon].Cells["Mã GV"].Value?.ToString();
                txtHoTen.Text = dgvGiangVien.Rows[hangChon].Cells["Họ Tên"].Value?.ToString();
                cmbKhoa.Text = dgvGiangVien.Rows[hangChon].Cells["Khoa/Viện"].Value?.ToString();
                txtSDT.Text = dgvGiangVien.Rows[hangChon].Cells["SĐT"].Value?.ToString();
                txtEmail.Text = dgvGiangVien.Rows[hangChon].Cells["Email"].Value?.ToString();
                txtMaGV.Enabled = false;
            }
        }

        private GiangVienDTO LayDuLieuTuForm()
        {
            return new GiangVienDTO
            {
                MaGV = txtMaGV.Text,
                HoTen = txtHoTen.Text,
                MaKhoa = cmbKhoa.SelectedValue.ToString(),
                SoDienThoai = txtSDT.Text,
                Email = txtEmail.Text
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGV.Text)) return;

            GiangVienDTO giangVienMoi = LayDuLieuTuForm();
            if (bll.Them(giangVienMoi))
            {
                TaiDanhSach();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVienDTO giangVienSua = LayDuLieuTuForm();
            if (bll.Sua(giangVienSua))
            {
                TaiDanhSach();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bll.Xoa(txtMaGV.Text))
            {
                TaiDanhSach();
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