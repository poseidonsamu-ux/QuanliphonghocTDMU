using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            LoadCacChiSo();
            LoadBieuDoThietBi();
        }

        private void LoadCacChiSo()
        {
            string sqlTongPhong = "SELECT COUNT(*) FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'";
            string sqlDangDung = "SELECT COUNT(DISTINCT MaPhong) FROM LichDatPhong WHERE NgayDat = CAST(GETDATE() AS DATE) AND TrangThaiDuyet = N'Đã duyệt'";
            string sqlChoDuyet = "SELECT COUNT(*) FROM LichDatPhong WHERE TrangThaiDuyet = N'Chờ duyệt'";

            int tongPhong = Convert.ToInt32(kn.ExecuteQuery(sqlTongPhong).Rows[0][0]);
            int dangDung = Convert.ToInt32(kn.ExecuteQuery(sqlDangDung).Rows[0][0]);
            int phongTrong = tongPhong - dangDung;
            int choDuyet = Convert.ToInt32(kn.ExecuteQuery(sqlChoDuyet).Rows[0][0]);

            lblPhongDangDung.Text = dangDung.ToString();
            lblPhongTrong.Text = phongTrong.ToString();
            lblChoDuyet.Text = choDuyet.ToString();
        }

        private void LoadBieuDoThietBi()
        {
            string sqlThietBi = "SELECT TinhTrang, SUM(SoLuong) AS TongSoLuong FROM TrangBiPhong GROUP BY TinhTrang";
            DataTable dt = kn.ExecuteQuery(sqlThietBi);

            chartThietBi.Series.Clear();
            chartThietBi.Titles.Clear();

            chartThietBi.Titles.Add("TỈ LỆ TÌNH TRẠNG THIẾT BỊ");
            chartThietBi.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);

            Series series = new Series("TinhTrang");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            chartThietBi.Series.Add(series);

            foreach (DataRow row in dt.Rows)
            {
                string tinhTrang = row["TinhTrang"].ToString();
                int soLuong = Convert.ToInt32(row["TongSoLuong"]);
                series.Points.AddXY(tinhTrang, soLuong);
            }
        }
    }
}