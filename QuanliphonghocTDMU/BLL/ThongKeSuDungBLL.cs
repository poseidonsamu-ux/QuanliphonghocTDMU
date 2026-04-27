using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThongKeSuDungBLL
    {
        ThongKeSuDungDAL dal = new ThongKeSuDungDAL();

        public DataTable LayDanhSach() => dal.LayDuLieuThongKe();

        public void XuatExcel(DataGridView dgv)
        {
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);

            // Ghi tiêu đề cột
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
                app.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

            // Ghi dữ liệu từ lưới
            for (int i = 0; i < dgv.Rows.Count; i++)
                for (int j = 0; j < dgv.Columns.Count; j++)
                    app.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();

            app.Columns.AutoFit();
            app.Visible = true;
        }
    }
}