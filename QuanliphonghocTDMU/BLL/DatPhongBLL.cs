using System;
using System.Data;
using System.IO;
using System.Globalization;
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
            if (dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc))
                return "Trùng lịch";

            dto.TrangThaiDuyet = (role == "Admin") ? "Đã duyệt" : "Chờ duyệt";

            return dal.ThemDatPhong(dto) ? "Thành công" : "Lỗi CSDL";
        }

        public string NhapTuExcel(string filePath, string role)
        {
            if (role != "Admin")
                return "Lỗi: Quyền Admin mới được nhập Excel.";

            // FIX CHO EPPLUS 8
            ExcelPackage.License.SetNonCommercialPersonal("TDMU");

            int countSuccess = 0;

            try
            {
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    var worksheet = package.Workbook.Worksheets[0];

                    for (int row = 2; row <= (worksheet.Dimension?.Rows ?? 0); row++)
                    {
                        try
                        {
                            var cellMaPhong = worksheet.Cells[row, 1].Value;

                            if (cellMaPhong == null)
                                continue;

                            DateTime ngayDat;
                            var rawNgay = worksheet.Cells[row, 3].Value;

                            if (rawNgay is DateTime dt)
                                ngayDat = dt;
                            else if (double.TryParse(rawNgay?.ToString(), out double d))
                                ngayDat = DateTime.FromOADate(d);
                            else
                                ngayDat = DateTime.Parse(rawNgay.ToString());

                            LichDatPhongDTO dto = new LichDatPhongDTO
                            {
                                MaPhong = cellMaPhong.ToString().Trim(),
                                MaGV = worksheet.Cells[row, 2].Value?.ToString().Trim(),
                                NgayDat = ngayDat,
                                CaHoc = Convert.ToInt32(worksheet.Cells[row, 4].Value),
                                TietBatDau = Convert.ToInt32(worksheet.Cells[row, 5].Value),
                                TietKetThuc = Convert.ToInt32(worksheet.Cells[row, 6].Value),
                                MucDich = worksheet.Cells[row, 7].Value?.ToString() ?? "",
                                TrangThaiDuyet = "Đã duyệt"
                            };

                            if (!dal.KiemTraTrungLich(dto.MaPhong, dto.NgayDat, dto.CaHoc))
                            {
                                if (dal.ThemDatPhong(dto))
                                    countSuccess++;
                            }
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }

                return $"Thành công {countSuccess} dòng.";
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
    }
}