using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU
{
    public class BaoCaoSuCoBLL
    {
        BaoCaoSuCoDAL dal = new BaoCaoSuCoDAL();
        public DataTable GetPhong() => dal.LayDanhSachPhong();
        public DataTable GetThietBiByPhong(string maP) => dal.LayThietBiTheoPhong(maP);
        public DataTable GetTatCaLoi() => dal.LayTatCaThietBiLoi();

        public string BaoHongThietBi(string maP, string maTB, string tinhTrangHienTai, int sl)
        {
            if (tinhTrangHienTai.Contains("Hư hỏng")) return "Đồ này đã báo hỏng rồi!";
            string ttMoi = "Hư hỏng (" + sl + " cái)";
            return dal.CapNhatTinhTrang(maP, maTB, ttMoi) ? "Thành công" : "Lỗi hệ thống!";
        }

        public bool SuaXongThietBi(string maP, string maTB) => dal.CapNhatTinhTrang(maP, maTB, "Bình thường");
    }
}