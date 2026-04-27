using System.Data;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU
{
    public class TraCuuBLL
    {
        TraCuuDAL dal = new TraCuuDAL();

        public DataTable GetToaNha() => dal.LayToaNha();
        public DataTable GetGiangVien() => dal.LayGiangVien();
        public DataTable GetThietBi(string maPhong) => dal.LayThietBiTheoPhong(maPhong);

        public DataTable GetPhongHoc(string maToaNha) => dal.LayPhongHocTheoToaNha(maToaNha);
        public DataTable GetPhongBiDat(string ngay, string ca) => dal.LayPhongDaBiDat(ngay, ca);

        public bool ThucHienDatPhong(LichDatPhongDTO ld)
        {
            if (ld.CaHoc == "1") ld.TietBatDau = 1;
            else if (ld.CaHoc == "2") ld.TietBatDau = 6;
            else ld.TietBatDau = 11;

            ld.TietKetThuc = ld.TietBatDau + 4;

            return dal.DatPhong(ld);
        }

        // THÊM MỚI: Gọi hàm xóa xuống DAL
        public bool HuyDatPhong(string maPhong, string ngay, string ca)
        {
            return dal.XoaDatPhong(maPhong, ngay, ca);
        }
    }
}