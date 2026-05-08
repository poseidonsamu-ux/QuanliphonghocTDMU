using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThietBiBLL
    {
        ThietBiDAL dal = new ThietBiDAL();

        public DataTable GetThietBi()
        {
            return dal.GetThietBi();
        }

        public bool Them(ThietBiDTO tb)
        {
            // Kiểm tra rỗng sơ bộ (có thể kiểm tra thêm ở GUI)
            if (string.IsNullOrEmpty(tb.MaTB) || string.IsNullOrEmpty(tb.TenTB))
                return false;
            return dal.Them(tb);
        }

        public bool Sua(ThietBiDTO tb)
        {
            return dal.Sua(tb);
        }

        public bool Xoa(string maTB)
        {
            return dal.Xoa(maTB);
        }
    }
}