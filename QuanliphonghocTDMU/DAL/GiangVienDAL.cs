using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class GiangVienDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachKhoa()
        {
            return kn.ExecuteQuery("SELECT MaKhoa, TenKhoa FROM KhoaVien");
        }

        public DataTable LayDanhSachGiangVien()
        {
            string chuoiTruyVan = @"SELECT g.MaGV AS [Mã GV], g.HoTen AS [Họ Tên], 
                                          k.TenKhoa AS [Khoa/Viện], g.SoDienThoai AS [SĐT], g.Email AS [Email]
                                   FROM GiangVien g
                                   JOIN KhoaVien k ON g.MaKhoa = k.MaKhoa";
            return kn.ExecuteQuery(chuoiTruyVan);
        }

        public bool ThemGiangVien(GiangVienDTO giangVien)
        {
            string chuoiThem = string.Format("INSERT INTO GiangVien VALUES ('{0}', N'{1}', '{2}', '{3}', '{4}')",
                giangVien.MaGV, giangVien.HoTen, giangVien.MaKhoa, giangVien.SoDienThoai, giangVien.Email);
            return kn.ExecuteNonQuery(chuoiThem);
        }

        public bool SuaGiangVien(GiangVienDTO giangVien)
        {
            string chuoiSua = string.Format("UPDATE GiangVien SET HoTen = N'{0}', MaKhoa = '{1}', SoDienThoai = '{2}', Email = '{3}' WHERE MaGV = '{4}'",
                giangVien.HoTen, giangVien.MaKhoa, giangVien.SoDienThoai, giangVien.Email, giangVien.MaGV);
            return kn.ExecuteNonQuery(chuoiSua);
        }

        public bool XoaGiangVien(string maGiangVien)
        {
            string chuoiXoa = string.Format("DELETE FROM GiangVien WHERE MaGV = '{0}'", maGiangVien);
            return kn.ExecuteNonQuery(chuoiXoa);
        }
    }
}