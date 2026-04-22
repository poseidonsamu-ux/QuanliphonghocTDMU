using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDuyetYeuCau : Form
    {
        DuyetYeuCauBLL bll = new DuyetYeuCauBLL();
        string maDatPhongDangChon = "";

        public frmDuyetYeuCau()
        {
            InitializeComponent();
        }

        private void frmDuyetYeuCau_Load(object sender, EventArgs e)
        {
            LoadDanhSachChoDuyet();
        }

        private void LoadDanhSachChoDuyet()
        {
            dgvYeuCau.DataSource = bll.LayDanhSach();
            maDatPhongDangChon = "";
            lblTrangThai.Text = "Đang chọn: Chưa có";
        }

        private void dgvYeuCau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maDatPhongDangChon = dgvYeuCau.Rows[e.RowIndex].Cells["Mã Đặt"].Value.ToString();
                string tenPhong = dgvYeuCau.Rows[e.RowIndex].Cells["Phòng"].Value.ToString();
                string giangVien = dgvYeuCau.Rows[e.RowIndex].Cells["Giảng Viên"].Value.ToString();
                lblTrangThai.Text = string.Format("Đang chọn: Duyệt cho {0} mượn {1}", giangVien, tenPhong);
            }
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maDatPhongDangChon))
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (bll.DuyetYeuCau(maDatPhongDangChon))
            {
                MessageBox.Show("Đã DUYỆT yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChoDuyet();
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maDatPhongDangChon))
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn TỪ CHỐI yêu cầu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (bll.TuChoiYeuCau(maDatPhongDangChon))
                {
                    MessageBox.Show("Đã TỪ CHỐI yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachChoDuyet();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachChoDuyet();
        }
    }
}