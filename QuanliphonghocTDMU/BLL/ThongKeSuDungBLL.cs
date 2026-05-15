using System;
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

            // 1. Ghi tiêu đề
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                app.Cells[1, i].Font.Bold = true;
            }

            // 2. Ghi dữ liệu
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    string giaTriO = dgv.Rows[i].Cells[j].FormattedValue?.ToString();

                    // 3. Xử lý ngày tháng để Excel không tự đảo ngược (Thêm dấu ')
                    if (dgv.Columns[j].ValueType == typeof(DateTime) || dgv.Columns[j].Name.Contains("Ngày") || dgv.Columns[j].Name.Contains("Ngay"))
                    {
                        app.Cells[i + 2, j + 1] = "'" + giaTriO;
                    }
                    else
                    {
                        app.Cells[i + 2, j + 1] = giaTriO;
                    }
                }
            }

            // 4. Căn chỉnh và hiển thị
            app.Columns.AutoFit();
            app.Visible = true;
        }
    }
}