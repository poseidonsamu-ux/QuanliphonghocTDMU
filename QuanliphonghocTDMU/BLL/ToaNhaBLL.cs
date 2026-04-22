using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class ToaNhaBLL
    {
        ToaNhaDAL dal = new ToaNhaDAL();

        public DataTable LayToaNha()
        {
            return dal.LayDanhSachToaNha();
        }

        public bool Them(ToaNhaDTO tn)
        {
            if (string.IsNullOrEmpty(tn.MaToaNha)) return false;
            return dal.ThemToaNha(tn);
        }

        public bool Sua(ToaNhaDTO tn)
        {
            if (string.IsNullOrEmpty(tn.MaToaNha)) return false;
            return dal.SuaToaNha(tn);
        }

        public bool Xoa(string maToaNha)
        {
            if (string.IsNullOrEmpty(maToaNha)) return false;
            return dal.XoaToaNha(maToaNha);
        }
    }
}