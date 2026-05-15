using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class PhongHocBLL
    {
        PhongHocDAL dal = new PhongHocDAL();

        // 1. Lấy dữ liệu
        public DataTable GetToaNha() => dal.LayDanhSachToaNha();
        public DataTable GetPhongHoc() => dal.LayDanhSachPhongHoc();

        // 2. Thêm/Sửa/Xóa với try-catch
        public bool Them(PhongHocDTO ph)
        {
            try { return dal.ThemPhong(ph); }
            catch { return false; }
        }

        public bool Sua(PhongHocDTO ph)
        {
            try { return dal.SuaPhong(ph); }
            catch { return false; }
        }

        public bool Xoa(string maPhong)
        {
            try { return dal.XoaPhong(maPhong); }
            catch { return false; }
        }

        // 3. Xuất Excel
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
            catch (Exception ex)
            {
                throw new Exception("Lỗi xuất Excel: " + ex.Message);
            }
        }

        // 4. Nhập Excel
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

                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    string ma = range.Cells[i, 1].Value?.ToString();
                    if (string.IsNullOrEmpty(ma)) continue;

                    PhongHocDTO ph = new PhongHocDTO
                    {
                        MaPhong = ma,
                        MaToaNha = range.Cells[i, 2].Value?.ToString(),
                        TenPhong = range.Cells[i, 3].Value?.ToString(),
                        Tang = range.Cells[i, 4].Value?.ToString(),
                        LoaiPhong = range.Cells[i, 5].Value?.ToString(),
                        SucChua = int.Parse(range.Cells[i, 6].Value?.ToString() ?? "40"),
                        TrangThai = range.Cells[i, 7].Value?.ToString() ?? "Sẵn sàng"
                    };
                    if (dal.ThemPhong(ph)) count++;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi đọc file Excel: " + ex.Message);
            }
            finally
            {
                if (wb != null) wb.Close(false);
                app.Quit();
            }
            return count;
        }

        // 5. Tải mẫu Excel
        public void TaiMau(string filePath)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;

                string[] headers = { "Mã Phòng", "Mã Tòa Nhà", "Tên Phòng", "Tầng", "Loại Phòng", "Sức Chứa", "Trạng Thái" };
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[1, i + 1] = headers[i];
                    ws.Cells[1, i + 1].Font.Bold = true;
                }

                wb.SaveAs(filePath);
                wb.Close();
                app.Quit();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi tạo file mẫu: " + ex.Message);
            }
        }
    }
}