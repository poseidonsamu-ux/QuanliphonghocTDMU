using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ToaNhaBLL
    {
        ToaNhaDAL dal = new ToaNhaDAL();

        public DataTable LayToaNha() => dal.LayDanhSachToaNha();

        // 1. Hàm Xuất Excel: Nhận DataGridView từ GUI truyền xuống
        public void XuatExcel(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0) return;
            Excel.Application app = new Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);

            // Ghi tiêu đề cột
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
                app.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

            // Ghi dữ liệu từng dòng
            for (int i = 0; i < dgv.Rows.Count; i++)
                for (int j = 0; j < dgv.Columns.Count; j++)
                    app.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].FormattedValue?.ToString();

            app.Columns.AutoFit();
            app.Visible = true;
        }

        // 2. Hàm Nhập Excel: Nhận đường dẫn file, trả về số dòng thành công
        public int NhapExcel(string filePath)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Open(filePath);
            Excel.Worksheet ws = wb.Sheets[1];
            Excel.Range range = ws.UsedRange;
            int count = 0;

            try
            {
                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    string ma = range.Cells[i, 1].Value?.ToString();
                    if (!string.IsNullOrEmpty(ma))
                    {
                        ToaNhaDTO tn = new ToaNhaDTO
                        {
                            MaToaNha = ma,
                            TenKhu = "Khu " + ma,
                            SoTang = int.Parse(range.Cells[i, 2].Value?.ToString() ?? "1"),
                            GhiChu = range.Cells[i, 3].Value?.ToString() ?? ""
                        };
                        if (dal.ThemToaNha(tn)) count++; // Gọi trực tiếp DAL để lưu
                    }
                }
            }
            finally
            {
                wb.Close(false);
                app.Quit();
            }
            return count;
        }

        // 3. Hàm Tải Mẫu: Tạo file mẫu trắng cho người dùng
        public void TaiMau(string savePath)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet ws = wb.ActiveSheet;
            ws.Cells[1, 1] = "Mã Tòa Nhà"; ws.Cells[1, 2] = "Số Tầng"; ws.Cells[1, 3] = "Ghi Chú";
            ws.Range["A1:C1"].Font.Bold = true;
            wb.SaveAs(savePath);
            wb.Close();
            app.Quit();
        }

        public bool Them(ToaNhaDTO tn) => dal.ThemToaNha(tn);
        public bool Sua(ToaNhaDTO tn) => dal.SuaToaNha(tn);
        public bool Xoa(string maToaNha) => dal.XoaToaNha(maToaNha);
    }
}