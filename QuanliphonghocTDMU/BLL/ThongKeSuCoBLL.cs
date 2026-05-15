using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThongKeSuCoBLL
    {
        ThongKeSuCoDAL dal = new ThongKeSuCoDAL();

        // Trả về DataTable để Form hiển thị
        public DataTable LayBangThongKe()
        {
            return dal.LayBangThongKe();
        }

        // Hàm xuất Excel trực tiếp trong BLL
        public void XuatExcelSuCo(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
            saveFileDialog.FileName = "ThongKeSuCo_TDMU";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.ActiveSheet;
                    excelWorksheet.Name = "ThongKeSuCo";

                    // Ghi Tiêu đề bảng
                    Excel.Range head = excelWorksheet.get_Range("A1", "H1"); // Có 8 cột
                    head.MergeCells = true;
                    head.Value2 = "BẢNG THỐNG KÊ SỰ CỐ PHÒNG HỌC TDMU";
                    head.Font.Bold = true;
                    head.Font.Size = 16;
                    head.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    // Lấy Tiêu đề cột
                    for (int i = 1; i <= dgv.Columns.Count; i++)
                    {
                        excelWorksheet.Cells[3, i] = dgv.Columns[i - 1].HeaderText;
                        ((Excel.Range)excelWorksheet.Cells[3, i]).Font.Bold = true;
                        ((Excel.Range)excelWorksheet.Cells[3, i]).Borders.LineStyle = Excel.Constants.xlSolid;
                    }

                    // Đổ Dữ liệu
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Value != null)
                            {
                                excelWorksheet.Cells[i + 4, j + 1] = dgv.Rows[i].Cells[j].FormattedValue?.ToString();
                                ((Excel.Range)excelWorksheet.Cells[i + 4, j + 1]).Borders.LineStyle = Excel.Constants.xlSolid;
                            }
                        }
                    }

                    excelWorksheet.Columns.AutoFit(); // Tự động giãn cột
                    excelWorkbook.SaveAs(saveFileDialog.FileName);
                    excelWorkbook.Close();
                    excelApp.Quit();

                    MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}