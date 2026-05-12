using System;
using System.Data;
using QuanLiPhongHocTDMU.DAL;

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

        public bool XoaLich(int maDatPhong) => dal.XoaLichDatPhong(maDatPhong);

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
    }
}