using QuanLiPhongHocTDMU.BLL;
using QuanLiPhongHocTDMU.DTO;
using System;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmQuanLiPhongHoc : Form
    {
        PhongHocBLL bll = new PhongHocBLL();

        public frmQuanLiPhongHoc()
        {
            InitializeComponent();
        }

        private void frmQuanLiPhongHoc_Load(object sender, EventArgs e)
        {
            LoadComboBoxToaNha();
            LoadDanhSachPhongHoc();

            if (cmbLoaiPhong.Items.Count > 0) cmbLoaiPhong.SelectedIndex = 0;
            if (cmbTrangThai.Items.Count > 0) cmbTrangThai.SelectedIndex = 0;
        }

        private void LoadComboBoxToaNha()
        {
            cmbToaNha.DataSource = bll.GetToaNha();
            cmbToaNha.DisplayMember = "TenKhu";
            cmbToaNha.ValueMember = "MaToaNha";
        }

        private void LoadDanhSachPhongHoc()
        {
            dgvPhongHoc.DataSource = bll.GetPhongHoc();
        }

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

                txtMaPhong.Enabled = false;
            }
        }

        private PhongHocDTO LayDataTuForm()
        {
            return new PhongHocDTO
            {
                MaPhong = txtMaPhong.Text,
                MaToaNha = cmbToaNha.SelectedValue.ToString(),
                TenPhong = txtTenPhong.Text,
                Tang = txtTang.Text,
                LoaiPhong = cmbLoaiPhong.Text,
                SucChua = string.IsNullOrEmpty(txtSucChua.Text) ? 40 : int.Parse(txtSucChua.Text),
                TrangThai = cmbTrangThai.Text
            };
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Phòng!"); return;
            }

            PhongHocDTO ph = LayDataTuForm();

            if (bll.Them(ph))
            {
                MessageBox.Show("Thêm phòng học thành công!");
                LoadDanhSachPhongHoc();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            PhongHocDTO ph = LayDataTuForm();

            if (bll.Sua(ph))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadDanhSachPhongHoc();
                btnLamMoi_Click(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll.Xoa(txtMaPhong.Text))
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