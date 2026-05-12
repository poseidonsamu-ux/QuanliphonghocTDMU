using System;
using System.Data;
using System.IO;
using OfficeOpenXml;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class DatPhongBLL
    {
        private DatPhongDAL dal = new DatPhongDAL();

        public DataTable LayDanhSachPhong() => dal.LayDanhSachPhong();
        public DataTable LayDanhSachGiangVien() => dal.LayDanhSachGiangVien();
        public DataTable LayChiTietGiangVien(string maGV) => dal.LayChiTietGiangVien(maGV);

        public string DatPhong(LichDatPhongDTO dto, string role)
        {
            if (dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc)) return "Trùng lịch";

            if (role == "Admin") dto.TrangThaiDuyet = "Đã duyệt";
            else dto.TrangThaiDuyet = "Chờ duyệt";

            if (dal.ThemDatPhong(dto)) return "Thành công";
            return "Lỗi CSDL";
        }

        public string NhapTuExcel(string filePath, string role)
        {
            if (role != "Admin") return "Lỗi: Chỉ Admin mới được phép nhập lịch từ Excel.";

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            int countSuccess = 0;

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        try
                        {
                            LichDatPhongDTO dto = new LichDatPhongDTO
                            {
                                MaPhong = worksheet.Cells[row, 1].Value?.ToString(),
                                MaGV = worksheet.Cells[row, 2].Value?.ToString(),
                                NgayDat = Convert.ToDateTime(worksheet.Cells[row, 3].Value),
                                CaHoc = Convert.ToInt32(worksheet.Cells[row, 4].Value),
                                TietBatDau = Convert.ToInt32(worksheet.Cells[row, 5].Value),
                                TietKetThuc = Convert.ToInt32(worksheet.Cells[row, 6].Value),
                                MucDich = worksheet.Cells[row, 7].Value?.ToString(),
                                TrangThaiDuyet = "Đã duyệt"
                            };

                            if (!dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc))
                            {
                                if (dal.ThemDatPhong(dto)) countSuccess++;
                            }
                        }
                        catch { continue; }
                    }
                }
                return $"Nhập thành công {countSuccess} lịch đặt phòng từ Excel (Các lịch trùng bị bỏ qua).";
            }
            catch (Exception ex)
            {
                return "Lỗi đọc file Excel: " + ex.Message;
            }
        }
    }
}