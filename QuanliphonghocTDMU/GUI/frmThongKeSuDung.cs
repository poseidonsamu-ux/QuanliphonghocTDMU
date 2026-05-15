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
            // 1. Load dữ liệu
            dgvThongKe.DataSource = bll.LayDanhSach();

            if (dgvThongKe.Columns.Count > 0)
            {
                foreach (DataGridViewColumn col in dgvThongKe.Columns)
                {
                    // 2. Bật sắp xếp (Sort)
                    col.SortMode = DataGridViewColumnSortMode.Automatic;

                    // 3. Format ngày/tháng/năm
                    if (col.ValueType == typeof(DateTime) || col.Name.Contains("Ngày") || col.Name.Contains("Ngay"))
                    {
                        col.DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvThongKe.Rows.Count > 0)
                {
                    bll.XuatExcel(dgvThongKe);
                    MessageBox.Show("Đã trích xuất dữ liệu sang Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}