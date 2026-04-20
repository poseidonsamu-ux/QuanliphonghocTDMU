using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiPhongHocTDMU
{
    public partial class frmTrangChu : Form
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            string role = frmDangNhap.Role;
            string maGV = frmDangNhap.MaGV;
            lblWelcome.Text = "XIN CHÀO, " + role.ToUpper();

            // 1. Thẻ xanh: Phòng trống (Chung cho cả 2)
            DataTable dtPhong = kn.ExecuteQuery("SELECT COUNT(*) FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'");
            lblPhongTrong.Text = dtPhong.Rows[0][0].ToString();

            if (role == "Admin")
            {
                // GIAO DIỆN ADMIN: Nhìn tổng quan toàn trường
                label4.Text = "YÊU CẦU CHỜ DUYỆT"; // Tiêu đề thẻ đỏ
                DataTable dtDuyet = kn.ExecuteQuery("SELECT COUNT(*) FROM LichDatPhong WHERE TrangThaiDuyet = N'Chờ duyệt'");
                lblChoDuyet.Text = dtDuyet.Rows[0][0].ToString();

                label6.Text = "TỔNG THIẾT BỊ"; // Tiêu đề thẻ xanh dương
                DataTable dtThietBi = kn.ExecuteQuery("SELECT COUNT(*) FROM ThietBi");
                lblThietBi.Text = dtThietBi.Rows[0][0].ToString();
                pnlThietBi.BackColor = System.Drawing.Color.CornflowerBlue;
            }
            else
            {
                // GIAO DIỆN GIẢNG VIÊN: Chỉ hiện thông tin cá nhân
                label4.Text = "ĐƠN ĐANG CHỜ DUYỆT"; // Đơn của riêng giảng viên này
                string sqlCho = string.Format("SELECT COUNT(*) FROM LichDatPhong WHERE MaGV = '{0}' AND TrangThaiDuyet = N'Chờ duyệt'", maGV);
                DataTable dtCho = kn.ExecuteQuery(sqlCho);
                lblChoDuyet.Text = dtCho.Rows[0][0].ToString();

                label6.Text = "LỊCH ĐÃ ĐƯỢC DUYỆT"; // Đổi thành xem lịch cá nhân
                string sqlDuyet = string.Format("SELECT COUNT(*) FROM LichDatPhong WHERE MaGV = '{0}' AND TrangThaiDuyet = N'Đã duyệt'", maGV);
                DataTable dtDuyet = kn.ExecuteQuery(sqlDuyet);
                lblThietBi.Text = dtDuyet.Rows[0][0].ToString();

                // Đổi màu thẻ thứ 3 sang màu cam cho khác biệt
                pnlThietBi.BackColor = System.Drawing.Color.Orange;
            }
        }
    }
}