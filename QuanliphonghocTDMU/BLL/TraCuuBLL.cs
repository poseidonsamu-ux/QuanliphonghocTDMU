using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TraCuuBLL
    {
        TraCuuDAL dal = new TraCuuDAL();

        // 1. Nạp danh sách tòa nhà
        public DataTable GetToaNhaCombobox()
        {
            DataTable dt = dal.GetToaNha();
            DataRow row = dt.NewRow(); row["MaToaNha"] = "ALL"; row["TenKhu"] = "-- Tất cả --";
            dt.Rows.InsertAt(row, 0); return dt;
        }

        // 2. Tra cứu danh sách phòng
        public DataTable GetDanhSachPhong(DateTime ngay, string ca, string toaNha, bool chiLayPhongTrong)
            => dal.GetDanhSachPhong(ngay, ca, toaNha, chiLayPhongTrong);

        // 3. Lấy danh sách yêu cầu
        public DataTable GetYeuCau(string maGV, string role) => dal.GetYeuCauMuonPhong(maGV, role);

        // 4. Kiểm tra xung đột
        public DataTable GetXungDot() => dal.GetXungDotLich();

        // 5. Xem chi tiết phòng
        public string GetChiTietPhong(string maPhong)
        {
            DataTable dtTB = dal.GetThietBiPhong(maPhong);
            DataTable dtSC = dal.GetSuCoPhong(maPhong);
            string chitiet = $"📺 THIẾT BỊ TRONG PHÒNG:\n";
            foreach (DataRow r in dtTB.Rows) chitiet += $"- {r["ThongTin"]}\n";
            chitiet += $"\n⚠️ LỊCH SỬ BÁO CÁO SỰ CỐ:\n";
            if (dtSC.Rows.Count == 0) chitiet += "- Không có sự cố nào.\n";
            foreach (DataRow r in dtSC.Rows)
                chitiet += $"- {Convert.ToDateTime(r["NgayBaoCao"]):dd/MM} [{r["TrangThai"]}]: {r["MoTa"]}\n";
            return chitiet;
        }

        // 6. Đặt phòng ngẫu nhiên và báo mail
        public string ThucHienBocPhong(DateTime ngay, string ca, string loaiPhong, string sucChua, string mucDichChung, string mucDichChiTiet, string maGV)
        {
            int caInt = int.Parse(ca);
            int sucChuaInt = int.Parse(sucChua);
            string ngayStr = ngay.ToString("yyyy-MM-dd");

            // Nối mục đích chung và chi tiết lại với nhau
            string mucDichFull = (mucDichChung == "Khác (Tự ghi)") ? mucDichChiTiet : $"{mucDichChung} - {mucDichChiTiet}".Trim(' ', '-');

            if (string.IsNullOrWhiteSpace(mucDichFull)) return "LỖI: Bạn chưa nhập mục đích mượn phòng!";

            // Gọi DAL truyền thêm tham số sức chứa
            string maPhongDuocBoc = dal.LayPhongRandomTheoYeuCau(ngayStr, caInt, loaiPhong, sucChuaInt);

            if (maPhongDuocBoc == null) return "HẾT PHÒNG: Rất tiếc, đã hết phòng loại này hoặc sức chứa này trong ca học bạn chọn!";

            YeuCauBocPhongDTO yc = new YeuCauBocPhongDTO
            {
                MaPhong = maPhongDuocBoc,
                MaGV = maGV,
                NgayDat = ngayStr,
                CaHoc = caInt,
                MucDich = mucDichFull,
                TrangThaiDuyet = "Chờ duyệt"
            };

            if (dal.LuuYeuCauBocPhong(yc))
            {
                string emailAdmin = "poseidonsamu@gmail.com";
                string tieuDe = "TDMU Rooms - Có yêu cầu đặt phòng mới";
                string noiDung = $"<h3>Ghi nhận yêu cầu đặt phòng</h3>" +
                                 $"<p><b>Giảng viên:</b> {maGV}</p>" +
                                 $"<p><b>Phòng đặt được:</b> {maPhongDuocBoc} (Sức chứa >= {sucChua})</p>" +
                                 $"<p><b>Thời gian:</b> Ngày {ngayStr}, Ca {caInt}</p>" +
                                 $"<p><b>Mục đích:</b> {mucDichFull}</p>";

                GuiEmailThongBao(emailAdmin, tieuDe, noiDung);

                return $"THÀNH CÔNG|Hệ thống đã đặt cho bạn phòng: {maPhongDuocBoc}\nYêu cầu đang chờ Admin phê duyệt.";
            }
            return "LỖI: Không thể kết nối cơ sở dữ liệu!";
        }

        // 7. Gửi email chạy ngầm
        private void GuiEmailThongBao(string emailNhan, string tieuDe, string noiDung)
        {
            Task.Run(() =>
            {
                try
                {
                    string emailGui = "bnzune22@gmail.com";
                    string matKhauApp = "oqcgazcysdxmrvgy";

                    SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential(emailGui, matKhauApp),
                        EnableSsl = true
                    };

                    MailMessage mail = new MailMessage(emailGui, emailNhan, tieuDe, noiDung);
                    mail.IsBodyHtml = true;

                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi gửi mail: " + ex.Message);
                }
            });
        }
    }
}