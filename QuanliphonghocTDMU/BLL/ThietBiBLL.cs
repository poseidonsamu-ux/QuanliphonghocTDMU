using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ThietBiBLL
    {
        ThietBiDAL dal = new ThietBiDAL();

        public DataTable LayThietBi()
        {
            return dal.LayDanhSachThietBi();
        }

        public bool Them(ThietBiDTO tb)
        {
            if (string.IsNullOrEmpty(tb.MaTB)) return false;
            return dal.ThemThietBi(tb);
        }

        public bool Sua(ThietBiDTO tb)
        {
            return dal.SuaThietBi(tb);
        }

        public bool Xoa(string maTB)
        {
            return dal.XoaThietBi(maTB);
        }
    }
}