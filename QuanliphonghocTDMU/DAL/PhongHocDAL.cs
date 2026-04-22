using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class PhongHocDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachToaNha()
        {
            return kn.ExecuteQuery("SELECT MaToaNha, TenKhu FROM ToaNha");
        }

        public DataTable LayDanhSachPhongHoc()
        {
            string sql = @"SELECT p.MaPhong AS [Mã Phòng], t.TenKhu AS [Tòa Nhà], 
                                  p.TenPhong AS [Tên Phòng], p.Tang AS [Tầng], 
                                  p.LoaiPhong AS [Loại Phòng], p.SucChua AS [Sức Chứa], p.TrangThai AS [Trạng Thái]
                           FROM PhongHoc p
                           JOIN ToaNha t ON p.MaToaNha = t.MaToaNha";
            return kn.ExecuteQuery(sql);
        }

        public bool ThemPhong(PhongHocDTO ph)
        {
            string sql = string.Format(
                "INSERT INTO PhongHoc(MaPhong, MaToaNha, TenPhong, Tang, LoaiPhong, SucChua, TrangThai) " +
                "VALUES ('{0}', '{1}', N'{2}', N'{3}', N'{4}', {5}, N'{6}')",
                ph.MaPhong, ph.MaToaNha, ph.TenPhong, ph.Tang, ph.LoaiPhong, ph.SucChua, ph.TrangThai);
            return kn.ExecuteNonQuery(sql);
        }

        public bool SuaPhong(PhongHocDTO ph)
        {
            string sql = string.Format(
                "UPDATE PhongHoc SET MaToaNha = '{0}', TenPhong = N'{1}', Tang = N'{2}', " +
                "LoaiPhong = N'{3}', SucChua = {4}, TrangThai = N'{5}' WHERE MaPhong = '{6}'",
                ph.MaToaNha, ph.TenPhong, ph.Tang, ph.LoaiPhong, ph.SucChua, ph.TrangThai, ph.MaPhong);
            return kn.ExecuteNonQuery(sql);
        }

        public bool XoaPhong(string maPhong)
        {
            string sql = string.Format("DELETE FROM PhongHoc WHERE MaPhong = '{0}'", maPhong);
            return kn.ExecuteNonQuery(sql);
        }
    }
}