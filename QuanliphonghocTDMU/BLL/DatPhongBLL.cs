using System;
using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiPhongHocTDMU.BLL
{
    public class DatPhongBLL
    {
        private DatPhongDAL dal = new DatPhongDAL();

        public DataTable LayDSPhong() => dal.LayDanhSachPhongSẵnSàng();
        public DataTable LayDSGV() => dal.LayDanhSachGiangVien();
        public DataTable LayChiTietGV(string maGV) => dal.LayChiTietGiangVien(maGV);

        public string XuLyDatPhong(LichDatPhongDTO dto, string role)
        {
            if (dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc)) return "Phòng đã có lịch!";
            dto.TrangThaiDuyet = (role == "Admin") ? "Đã duyệt" : "Chờ duyệt";
            return dal.ThemDatPhong(dto) ? "Thành công" : "Lỗi hệ thống";
        }

        // Hàm Nhập dữ liệu đặt phòng từ Excel 
        public string NhapTuExcel(string filePath, string role)
        {
            if (role != "Admin") return "Lỗi: Chỉ Admin mới có quyền nhập từ Excel!";

            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = null;
            int count = 0;

            try
            {
                wb = app.Workbooks.Open(filePath);
                Excel.Worksheet ws = wb.Sheets[1];
                Excel.Range range = ws.UsedRange;

                // Chạy từ dòng 2 để bỏ qua dòng tiêu đề
                for (int i = 2; i <= range.Rows.Count; i++)
                {
                    string maPhong = range.Cells[i, 1].Value?.ToString();
                    if (string.IsNullOrEmpty(maPhong)) continue;

                    // Xử lý ngày tháng
                    DateTime ngayDat = DateTime.Now;
                    var rawNgay = range.Cells[i, 3].Value;
                    if (rawNgay is DateTime dt) ngayDat = dt;
                    else if (double.TryParse(rawNgay?.ToString(), out double d)) ngayDat = DateTime.FromOADate(d);
                    else DateTime.TryParse(rawNgay?.ToString(), out ngayDat);

                    LichDatPhongDTO dto = new LichDatPhongDTO
                    {
                        MaPhong = maPhong,
                        MaGV = range.Cells[i, 2].Value?.ToString(),
                        NgayDat = ngayDat,
                        CaHoc = Convert.ToInt32(range.Cells[i, 4].Value),
                        TietBatDau = Convert.ToInt32(range.Cells[i, 5].Value),
                        TietKetThuc = Convert.ToInt32(range.Cells[i, 6].Value),
                        MucDich = range.Cells[i, 7].Value?.ToString() ?? "",
                        TrangThaiDuyet = "Đã duyệt"
                    };

                    // Kiểm tra trùng lịch trước khi thêm
                    if (!dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc))
                    {
                        if (dal.ThemDatPhong(dto)) count++;
                    }
                }
                return $"Nhập thành công {count} lịch đặt phòng!";
            }
            catch (Exception ex)
            {
                return "Lỗi đọc Excel: " + ex.Message;
            }
            finally
            {
                if (wb != null) wb.Close(false);
                app.Quit();
            }
        }
    }
}