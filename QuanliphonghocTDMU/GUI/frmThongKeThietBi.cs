using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU
{
    public partial class frmThongKeThietBi : Form
    {
        ThongKeThietBiBLL bll = new ThongKeThietBiBLL();

        public frmThongKeThietBi() { InitializeComponent(); }

        private void frmThongKeThietBi_Load(object sender, EventArgs e)
        {
            // Gọi hàm LayBangThongKe
            dgvThietBi.DataSource = bll.LayBangThongKe();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Gọi hàm XuatExcelThietBi
            bll.XuatExcelThietBi(dgvThietBi);
        }
    }
}