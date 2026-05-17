using System;
using System.Data;
using System.Windows.Forms;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class GiangVienBLL
    {
        GiangVienDAL dal = new GiangVienDAL();

        public DataTable LayKhoa() => dal.LayDanhSachKhoa();
        public DataTable LayGiangVien() => dal.LayDanhSachGiangVien();

        // 1. Nghiệp vụ CRUD
        public bool Them(GiangVienDTO gv)
        {
            try { return dal.ThemGiangVien(gv); }
            catch { return false; }
        }

        public bool Sua(GiangVienDTO gv)
        {
            try { return dal.SuaGiangVien(gv); }
            catch { return false; }
        }

        public bool Xoa(string maGV)
        {
            try { return dal.XoaGiangVien(maGV); }
            catch { return false; }
        }

        // 2. Hàm Tải File Mẫu Excel
        public void TaiMau(string filePath)
        {
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet ws = wb.ActiveSheet;

                // Ghi Header theo đúng bảng GiangVien
                string[] headers = { "Mã GV", "Họ Tên", "Mã Khoa", "SĐT", "Email" };
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[1, i + 1] = headers[i];
                    ws.Cells[1, i + 1].Font.Bold = true;
                }

                wb.SaveAs(filePath);
                wb.Close();
                app.Quit();
            }
            catch (Exception ex) { throw new Exception("Lỗi tạo mẫu: " + ex.Message); }
        }

        // 3. Hàm Xuất Excel từ DataGridView
        public void XuatExcel(DataGridView dgv)
        {
            try
            {
                if (dgv.Rows.Count == 0) return;
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

        // 4. Hàm Nhập dữ liệu từ Excel
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

                    GiangVienDTO gv = new GiangVienDTO
                    {
                        MaGV = ma,
                        HoTen = range.Cells[i, 2].Value?.ToString(),
                        MaKhoa = range.Cells[i, 3].Value?.ToString(),
                        SoDienThoai = range.Cells[i, 4].Value?.ToString(),
                        Email = range.Cells[i, 5].Value?.ToString()
                    };
                    if (dal.ThemGiangVien(gv)) count++;
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi đọc Excel: " + ex.Message); }
            finally { if (wb != null) wb.Close(false); app.Quit(); }
            return count;
        }
    }
}