using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmThongKeSuDung : Form
    {
        ThongKeSuDungBLL bll = new ThongKeSuDungBLL();

        public frmThongKeSuDung() { InitializeComponent(); }

        private void frmThongKeSuDung_Load(object sender, EventArgs e)
        {
            dgvThongKe.DataSource = bll.LayDanhSach();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                bll.XuatExcel(dgvThongKe);
                MessageBox.Show("Đã trích xuất dữ liệu sang Excel thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message);
            }
        }
    }
}