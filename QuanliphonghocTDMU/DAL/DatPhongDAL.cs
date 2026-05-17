using System;
using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class DatPhongDAL
    {
        private KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachPhongSẵnSàng() => kn.ExecuteQuery("SELECT MaPhong, SucChua FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'");
        public DataTable LayDanhSachGiangVien() => kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");

        public DataTable LayChiTietGiangVien(string maGV)
        {
            return kn.ExecuteQuery($@"SELECT G.HoTen, K.TenKhoa, G.SoDienThoai FROM GiangVien G 
                                     JOIN KhoaVien K ON G.MaKhoa = K.MaKhoa WHERE G.MaGV = '{maGV}'");
        }

        public bool KiemTraTrungLich(string maPhong, DateTime ngay, int ca)
        {
            DataTable dt = kn.ExecuteQuery($@"SELECT * FROM LichDatPhong WHERE MaPhong='{maPhong}' 
                                            AND NgayDat='{ngay:yyyy-MM-dd}' AND CaHoc={ca} AND TrangThaiDuyet != N'Từ chối'");
            return dt.Rows.Count > 0;
        }

        public bool ThemDatPhong(LichDatPhongDTO dto)
        {
            string sql = $@"INSERT INTO LichDatPhong VALUES('{dto.MaPhong}', '{dto.MaGV}', '{dto.NgayDat:yyyy-MM-dd}', 
                            {dto.CaHoc}, {dto.TietBatDau}, {dto.TietKetThuc}, N'{dto.MucDich}', N'{dto.TrangThaiDuyet}')";
            return kn.ExecuteNonQuery(sql);
        }
    }
}