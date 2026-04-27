using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThongKeThietBiBLL
    {
        ThongKeThietBiDAL dal = new ThongKeThietBiDAL();

        // Hàm lấy dữ liệu: Phải gọi đúng LayDuLieuThongKe từ DAL
        public DataTable LayBangThongKe()
        {
            return dal.LayDuLieuThongKe();
        }

        // Hàm xuất Excel: Tên chuẩn là XuatExcelThietBi
        public void XuatExcelThietBi(DataGridView dgv)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                    app.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                for (int i = 0; i < dgv.Rows.Count; i++)
                    for (int j = 0; j < dgv.Columns.Count; j++)
                        app.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                app.Columns.AutoFit();
                app.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}