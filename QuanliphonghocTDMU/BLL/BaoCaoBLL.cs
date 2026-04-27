using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class BaoCaoBLL
    {
        BaoCaoDAL dal = new BaoCaoDAL();

        public DataTable TaiLichSu() => dal.LayLichSuMuonPhong();

        public void ExportToExcel(DataGridView dgv)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                // Ghi Header
                for (int i = 1; i < dgv.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    excelApp.Cells[1, i].Font.Bold = true;
                }

                // Ghi dữ liệu
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        excelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi API Excel: " + ex.Message);
            }
        }
    }
}