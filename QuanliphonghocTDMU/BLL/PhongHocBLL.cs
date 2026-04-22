using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class PhongHocBLL
    {
        PhongHocDAL dal = new PhongHocDAL();

        public DataTable GetToaNha()
        {
            return dal.LayDanhSachToaNha();
        }

        public DataTable GetPhongHoc()
        {
            return dal.LayDanhSachPhongHoc();
        }

        public bool Them(PhongHocDTO ph)
        {
            if (string.IsNullOrEmpty(ph.MaPhong)) return false;
            return dal.ThemPhong(ph);
        }

        public bool Sua(PhongHocDTO ph)
        {
            return dal.SuaPhong(ph);
        }

        public bool Xoa(string maPhong)
        {
            return dal.XoaPhong(maPhong);
        }
    }
}