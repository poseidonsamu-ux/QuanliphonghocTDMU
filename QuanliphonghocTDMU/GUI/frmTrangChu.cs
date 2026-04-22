using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTrangChu : Form
    {
        TrangChuBLL bll = new TrangChuBLL();

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            CapNhatThongKe();
            TaiLichHoc();
        }

        private void CapNhatThongKe()
        {
            DataTable dt = bll.TaiThongKe();
            if (dt.Rows.Count > 0)
            {
                lblPhongDangDung.Text = dt.Rows[0]["DangDung"].ToString();
                lblPhongTrong.Text = dt.Rows[0]["PhongTrong"].ToString();
                lblChoDuyet.Text = dt.Rows[0]["ChoDuyet"].ToString();
            }
        }

        private void TaiLichHoc()
        {
            // Lấy MaGV từ biến static bên frmDangNhap
            string maGVHienTai = frmDangNhap.MaGV;

            DataTable dt = bll.TaiLichDay(maGVHienTai);
            dgvLichHomNay.DataSource = dt;

            // Chỉnh giao diện lưới cho đẹp
            if (dgvLichHomNay.Columns.Count > 0)
            {
                dgvLichHomNay.Columns[0].HeaderText = "Phòng Học";
                dgvLichHomNay.Columns[1].HeaderText = "Ca Dạy";
                dgvLichHomNay.Columns[2].HeaderText = "Mục Đích";
                dgvLichHomNay.Columns[3].HeaderText = "Trạng Thái";
                dgvLichHomNay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (pnlPhongDangDung != null && pnlPhongTrong != null && pnlChoDuyet != null)
            {
                int khoangCach = 30;
                int tongChieuRong = pnlPhongDangDung.Width + pnlPhongTrong.Width + pnlChoDuyet.Width + (khoangCach * 2);
                int diemBatDauX = (this.ClientSize.Width - tongChieuRong) / 2;

                pnlPhongDangDung.Location = new Point(diemBatDauX, 20);
                pnlPhongTrong.Location = new Point(diemBatDauX + pnlPhongDangDung.Width + khoangCach, 20);
                pnlChoDuyet.Location = new Point(pnlPhongTrong.Location.X + pnlPhongTrong.Width + khoangCach, 20);
            }
        }
    }
}