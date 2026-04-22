using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class BaoCaoSuCoBLL
    {
        BaoCaoSuCoDAL dal = new BaoCaoSuCoDAL();

        public DataTable GetPhong()
        {
            return dal.LayDanhSachPhong();
        }

        public DataTable GetThietBiByPhong(string maPhong)
        {
            if (string.IsNullOrEmpty(maPhong)) return null;
            return dal.LayThietBiTheoPhong(maPhong);
        }

        public string BaoHongThietBi(string maPhong, string maTB, string tinhTrangHienTai)
        {
            if (tinhTrangHienTai == "Hư hỏng")
                return "Thiết bị này đã được báo hỏng trước đó rồi!";

            bool kq = dal.CapNhatTinhTrang(maPhong, maTB, "Hư hỏng");
            return kq ? "Thành công" : "Lỗi khi cập nhật trạng thái!";
        }

        public bool SuaXongThietBi(string maPhong, string maTB)
        {
            return dal.CapNhatTinhTrang(maPhong, maTB, "Bình thường");
        }
    }
}