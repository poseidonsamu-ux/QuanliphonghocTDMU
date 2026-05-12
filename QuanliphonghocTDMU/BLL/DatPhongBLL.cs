using System;
using System.Data;
using System.IO;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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

            if (dal.ThemDatPhong(dto))
            {
                // Nếu người đặt không phải Admin (tức là Giảng viên đặt và đang Chờ duyệt)
                // thì hệ thống tự động bắn mail báo cho Admin biết
                if (role != "Admin")
                {
                    GuiMailThongBaoAdmin(dto);
                }
                return "Thành công";
            }

            return "Lỗi CSDL";
        }

        // ==============================================================
        // HÀM MỚI: TỰ ĐỘNG GỬI MAIL CHO ADMIN KHI CÓ NGƯỜI ĐẶT PHÒNG
        // ==============================================================
        private void GuiMailThongBaoAdmin(LichDatPhongDTO dto)
        {
            string emailAdmin = "poseidonsamu@gmail.com";
            string emailGui = "bnzune22@gmail.com";
            string matKhauApp = "dlmubrleysfwuvhz"; // Mã 16 ký tự của ông

            string tieuDe = "TDMU Rooms - Có yêu cầu đặt phòng mới chờ duyệt";
            string noiDung = $@"
                <h3>Hệ thống ghi nhận yêu cầu đặt phòng mới</h3>
                <p><b>Giảng viên:</b> {dto.MaGV}</p>
                <p><b>Phòng:</b> {dto.MaPhong}</p>
                <p><b>Thời gian:</b> Ngày {dto.NgayDat:dd/MM/yyyy}, Ca {dto.CaHoc}</p>
                <p><b>Mục đích:</b> {dto.MucDich}</p>
                <p>Vui lòng đăng nhập hệ thống bằng tài khoản Admin để xét duyệt.</p>";

            // Chạy ngầm để không làm đơ giao diện lúc đang gửi mail
            Task.Run(() =>
            {
                try
                {
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(emailGui, matKhauApp),
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network
                    };

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(emailGui, "TDMU Rooms System", Encoding.UTF8);
                    mail.To.Add(emailAdmin);
                    mail.Subject = tieuDe;
                    mail.Body = noiDung;
                    mail.IsBodyHtml = true;

                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi gửi mail cho Admin: " + ex.Message);
                }
            });
        }
        // ==============================================================

        public string NhapTuExcel(string filePath, string role)
        {
            if (role != "Admin")
                return "Lỗi: Quyền Admin mới được nhập Excel.";

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