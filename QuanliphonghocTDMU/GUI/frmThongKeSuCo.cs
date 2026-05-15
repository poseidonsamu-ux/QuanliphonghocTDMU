using System;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.BLL;

namespace QuanLiPhongHocTDMU.GUI
{
    public partial class frmThongKeSuCo : Form
    {
        ThongKeSuCoBLL bll = new ThongKeSuCoBLL();

        public frmThongKeSuCo()
        {
            InitializeComponent();
        }

        private void frmThongKeSuCo_Load(object sender, EventArgs e)
        {
            dgvSuCo.DataSource = bll.LayBangThongKe();

            if (dgvSuCo.Columns["Ngày Báo Cáo"] != null)
            {
                dgvSuCo.Columns["Ngày Báo Cáo"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            // Bật tính năng nhấp vào tiêu đề cột để sắp xếp (Sort)
            if (dgvSuCo.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvSuCo.Columns)
                {
                    col.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            // Gọi hàm xuất Excel từ BLL và truyền DataGridView vào
            bll.XuatExcelSuCo(dgvSuCo);
        }
    }
}