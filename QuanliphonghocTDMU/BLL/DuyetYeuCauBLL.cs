using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class DuyetYeuCauBLL
    {
        TraCuuDAL dal = new TraCuuDAL();

        public DataTable LayDanhSach()
        {
            return dal.GetYeuCauMuonPhong("", "Admin");
        }

        public bool DuyetYeuCau(string maDatPhong)
        {
            int maDat = int.Parse(maDatPhong);
            bool thanhCong = dal.CapNhatTrangThaiYeuCau(maDat, "Đã duyệt");

            if (thanhCong)
            {
                GuiMailChoGiangVien(maDat, "Đã duyệt");
            }
            return thanhCong;
        }

        public bool TuChoiYeuCau(string maDatPhong)
        {
            int maDat = int.Parse(maDatPhong);
            bool thanhCong = dal.CapNhatTrangThaiYeuCau(maDat, "Từ chối");

            if (thanhCong)
            {
                GuiMailChoGiangVien(maDat, "Từ chối");
            }
            return thanhCong;
        }

        private void GuiMailChoGiangVien(int maDat, string trangThai)
        {
            string emailGV = dal.GetEmailGiangVienByMaDat(maDat);

            if (!string.IsNullOrEmpty(emailGV))
            {
                string mauChu = (trangThai == "Đã duyệt") ? "green" : "red";
                string tieuDe = "TDMU Rooms - Kết quả xét duyệt phòng";
                string noiDung = $"<h3>Thông báo từ Ban Quản Trị TDMU</h3>" +
                                 $"<p>Yêu cầu mượn phòng mã số <b>#{maDat}</b> của thầy/cô đã được xử lý.</p>" +
                                 $"<p>Kết quả: <b style='color:{mauChu};'>{trangThai}</b></p>";

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

                        MailMessage mail = new MailMessage(emailGui, emailGV, tieuDe, noiDung);
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
}