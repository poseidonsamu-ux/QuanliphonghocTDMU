using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmDuyetYeuCau : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();
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
            // Chỉ lấy những yêu cầu đang ở trạng thái 'Chờ duyệt'
            string sql = @"
                SELECT 
                    l.MaDatPhong AS [Mã Đặt], 
                    p.TenPhong AS [Phòng], 
                    g.HoTen AS [Giảng Viên], 
                    l.NgayDat AS [Ngày Đặt], 
                    l.CaHoc AS [Ca], 
                    l.MucDich AS [Mục Đích],
                    l.TrangThaiDuyet AS [Trạng Thái]
                FROM LichDatPhong l
                JOIN PhongHoc p ON l.MaPhong = p.MaPhong
                JOIN GiangVien g ON l.MaGV = g.MaGV
                WHERE l.TrangThaiDuyet = N'Chờ duyệt'
                ORDER BY l.NgayDat ASC";

            dgvYeuCau.DataSource = kn.ExecuteQuery(sql);
            maDatPhongDangChon = ""; // Reset
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
            if (maDatPhongDangChon == "")
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sql = string.Format("UPDATE LichDatPhong SET TrangThaiDuyet = N'Đã duyệt' WHERE MaDatPhong = {0}", maDatPhongDangChon);
            if (kn.ExecuteNonQuery(sql))
            {
                MessageBox.Show("Đã DUYỆT yêu cầu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachChoDuyet();
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (maDatPhongDangChon == "")
            {
                MessageBox.Show("Vui lòng chọn một yêu cầu từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hỏi lại cho chắc chắn
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn TỪ CHỐI yêu cầu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = string.Format("UPDATE LichDatPhong SET TrangThaiDuyet = N'Từ chối' WHERE MaDatPhong = {0}", maDatPhongDangChon);
                if (kn.ExecuteNonQuery(sql))
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