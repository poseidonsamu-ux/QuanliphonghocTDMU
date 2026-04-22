using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class GiangVienBLL
    {
        GiangVienDAL dal = new GiangVienDAL();

        public DataTable LayKhoa()
        {
            return dal.LayDanhSachKhoa();
        }

        public DataTable LayGiangVien()
        {
            return dal.LayDanhSachGiangVien();
        }

        public bool Them(GiangVienDTO giangVien)
        {
            if (string.IsNullOrEmpty(giangVien.MaGV)) return false;
            return dal.ThemGiangVien(giangVien);
        }

        public bool Sua(GiangVienDTO giangVien)
        {
            return dal.SuaGiangVien(giangVien);
        }

        public bool Xoa(string maGiangVien)
        {
            return dal.XoaGiangVien(maGiangVien);
        }
    }
}