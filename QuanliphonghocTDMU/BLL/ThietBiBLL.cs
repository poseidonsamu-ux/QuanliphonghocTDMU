using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThietBiBLL
    {
        ThietBiDAL dal = new ThietBiDAL();

        public DataTable GetThietBi() => dal.GetThietBi();

        public bool Them(ThietBiDTO tb)
        {
            try { return dal.Them(tb); }
            catch { return false; }
        }

        public bool Sua(ThietBiDTO tb)
        {
            try { return dal.Sua(tb); }
            catch { return false; }
        }

        public bool Xoa(string maTB)
        {
            try { return dal.Xoa(maTB); }
            catch { return false; }
        }

        // 1. Hàm Tải File Mẫu Excel
        public void TaiMau(string filePath)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;

                // Ghi Header mẫu dựa theo bảng ThietBi trong SQL
                ws.Cells[1, 1] = "Mã TB";
                ws.Cells[1, 2] = "Tên Thiết Bị";
                ws.Cells[1, 3] = "Loại TB";
                ws.Range["A1:C1"].Font.Bold = true;

                wb.SaveAs(filePath);
                wb.Close();
                app.Quit();
            }
            catch (Exception ex) { throw new Exception("Lỗi tạo file mẫu: " + ex.Message); }
        }

        // 2. Hàm Xuất toàn bộ danh sách ra Excel
        public void XuatExcel(DataGridView dgv)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                app.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    app.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    app.Cells[1, i].Font.Bold = true;
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        app.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].FormattedValue?.ToString();
                    }
                }

                app.Columns.AutoFit();
                app.Visible = true;
            }
            catch (Exception ex) { throw new Exception("Lỗi xuất Excel: " + ex.Message); }
        }

        // 3. Hàm Nhập dữ liệu từ Excel vào Database
        public int NhapExcel(string filePath)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = null;
            int count = 0;

            try
            {
                wb = app.Workbooks.Open(filePath);
                Excel.Worksheet ws = wb.Sheets[1];
                Excel.Range range = ws.UsedRange;

                for (int row = 2; row <= range.Rows.Count; row++)
                {
                    string ma = range.Cells[row, 1].Value?.ToString();
                    if (string.IsNullOrEmpty(ma)) continue;

                    ThietBiDTO tb = new ThietBiDTO
                    {
                        MaTB = ma,
                        TenTB = range.Cells[row, 2].Value?.ToString(),
                        LoaiTB = range.Cells[row, 3].Value?.ToString()
                    };
                    if (dal.Them(tb)) count++;
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc Excel: " + ex.Message); }
            finally { if (wb != null) wb.Close(false); app.Quit(); }
            return count;
        }
    }
}