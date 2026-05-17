using System;
using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class BaoCaoSuCoBLL
    {
        BaoCaoSuCoDAL dal = new BaoCaoSuCoDAL();

        public DataTable GetPhongCuaGiangVien(string maGV) => dal.GetPhongCuaGiangVien(maGV);

        public bool GuiBaoCao(string maPhong, string maGV, string loaiSuCo, string moTa, int mucDo)
        {
            if (string.IsNullOrEmpty(loaiSuCo) || string.IsNullOrEmpty(moTa)) return false;
            return dal.GuiBaoCao(maPhong, maGV, loaiSuCo, moTa, mucDo);
        }

        public DataTable LayGoiYPhong(string maPhongGoc, DateTime ngay, int ca) => dal.SuggestPhongThayThe(maPhongGoc, ngay, ca);
        public DataTable GetThongKe() => dal.GetThongKe();
        public DataTable GetDanhSachSuCo() => dal.GetDanhSachSuCo();
        public bool XacNhanDaXuLy(int id) => dal.XacNhanXuLy(id);

        public bool CapNhatTrangThai(int id, string trangThai) => dal.CapNhatTrangThai(id, trangThai);
        public bool XoaSuCo(int id) => dal.XoaSuCo(id);
    }
}