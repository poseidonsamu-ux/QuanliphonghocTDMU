using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class DuyetYeuCauBLL
    {
        DuyetYeuCauDAL dal = new DuyetYeuCauDAL();

        public DataTable LayDanhSach()
        {
            return dal.GetYeuCauMuonPhong("", "Admin");
        }

        public bool DuyetYeuCau(string maDatPhong)
        {
            int maDat = int.Parse(maDatPhong);
            bool thanhCong = dal.CapNhatTrangThaiYeuCau(maDat, "Đã duyệt");
            if (thanhCong) GuiMailChoGiangVien(maDat, "Đã duyệt");
            return thanhCong;
        }

        public bool TuChoiYeuCau(string maDatPhong)
        {
            int maDat = int.Parse(maDatPhong);
            bool thanhCong = dal.CapNhatTrangThaiYeuCau(maDat, "Từ chối");
            if (thanhCong) GuiMailChoGiangVien(maDat, "Từ chối");
            return thanhCong;
        }

        private void GuiMailChoGiangVien(int maDat, string trangThai)
        {
            string emailNhan = dal.GetEmailGiangVienByMaDat(maDat);

            if (string.IsNullOrEmpty(emailNhan)) return;

            string emailGui = "bnzune22@gmail.com";
            string matKhauApp = "dlmubrleysfwuvhz"; 

            string mauChu = (trangThai == "Đã duyệt") ? "#16a34a" : "#dc2626";
            string tieuDe = "TDMU Rooms - Kết quả xét duyệt mượn phòng";
            string noiDung = $@"
                <div style='font-family: Arial, sans-serif; border: 1px solid #ddd; padding: 20px; border-radius: 10px;'>
                    <h2 style='color: #6b28d9;'>TDMU Rooms Thông Báo</h2>
                    <p>Chào thầy/cô, yêu cầu mượn phòng mã đơn <b>#{maDat}</b> đã được xử lý.</p>
                    <p style='font-size: 18px;'>Kết quả: <b style='color:{mauChu};'>{trangThai.ToUpper()}</b></p>
                    <hr/>
                    <p style='font-size: 12px; color: gray;'>Đây là email tự động, vui lòng không phản hồi mail này.</p>
                </div>";

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
                    mail.From = new MailAddress(emailGui, "Ban Quản Trị TDMU Rooms", Encoding.UTF8);
                    mail.To.Add(emailNhan);
                    mail.Subject = tieuDe;
                    mail.Body = noiDung;
                    mail.IsBodyHtml = true;

                    smtp.Send(mail);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi gửi mail cho GV: " + ex.Message);
                }
            });
        }
    }
}