using System;
using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TraCuuBLL
    {
        TraCuuDAL dal = new TraCuuDAL();

        public DataTable GetToaNhaCombobox()
        {
            DataTable dt = dal.GetToaNha();
            DataRow row = dt.NewRow(); row["MaToaNha"] = "ALL"; row["TenKhu"] = "-- Tất cả --";
            dt.Rows.InsertAt(row, 0); return dt;
        }

        public DataTable GetDanhSachPhong(DateTime ngay, string ca, string toaNha, bool chiLayPhongTrong)
            => dal.GetDanhSachPhong(ngay, ca, toaNha, chiLayPhongTrong);

        public DataTable GetYeuCau(string maGV, string role) => dal.GetYeuCauMuonPhong(maGV, role);

        public bool DuyetYeuCau(int maDat, string trangThai) => dal.CapNhatTrangThaiYeuCau(maDat, trangThai);

        public DataTable GetXungDot() => dal.GetXungDotLich();

        public string GetChiTietPhong(string maPhong)
        {
            DataTable dtTB = dal.GetThietBiPhong(maPhong);
            DataTable dtSC = dal.GetSuCoPhong(maPhong);
            string chitiet = $"📺 THIẾT BỊ TRONG PHÒNG:\n";
            foreach (DataRow r in dtTB.Rows) chitiet += $"- {r["ThongTin"]}\n";
            chitiet += $"\n⚠️ LỊCH SỬ BÁO CÁO SỰ CỐ:\n";
            if (dtSC.Rows.Count == 0) chitiet += "- Không có sự cố nào.\n";
            foreach (DataRow r in dtSC.Rows) chitiet += $"- {Convert.ToDateTime(r["NgayBaoCao"]):dd/MM} [{r["TrangThai"]}]: {r["MoTa"]}\n";
            return chitiet;
        }

        // Logic Bốc phòng (Gacha) cho Giảng viên
        public string ThucHienBocPhong(DateTime ngay, string ca, string loaiPhong, string mucDich, string maGV)
        {
            if (string.IsNullOrWhiteSpace(mucDich)) return "LỖI: Bạn chưa nhập mục đích mượn phòng!";
            int caInt = int.Parse(ca);
            string ngayStr = ngay.ToString("yyyy-MM-dd");

            string maPhongDuocBoc = dal.LayPhongRandomTheoYeuCau(ngayStr, caInt, loaiPhong);
            if (maPhongDuocBoc == null) return "HẾT PHÒNG: Rất tiếc, đã hết phòng loại này trong ca học bạn chọn!";

            YeuCauBocPhongDTO yc = new YeuCauBocPhongDTO
            {
                MaPhong = maPhongDuocBoc,
                MaGV = maGV,
                NgayDat = ngayStr,
                CaHoc = caInt,
                MucDich = mucDich,
                TrangThaiDuyet = "Chờ duyệt"
            };

            if (dal.LuuYeuCauBocPhong(yc))
                return $"THÀNH CÔNG|Hệ thống đã bốc cho bạn phòng: {maPhongDuocBoc}\nYêu cầu đang chờ Admin phê duyệt.";
            return "LỖI: Không thể kết nối cơ sở dữ liệu!";
        }
    }
}