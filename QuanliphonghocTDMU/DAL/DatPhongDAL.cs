using System;
using System.Data;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class DatPhongDAL
    {
        private KetNoiCSDL kn = new KetNoiCSDL();

        public DataTable LayDanhSachPhong()
        {
            return kn.ExecuteQuery("SELECT MaPhong, SucChua FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'");
        }

        public DataTable LayDanhSachGiangVien()
        {
            return kn.ExecuteQuery("SELECT MaGV, HoTen FROM GiangVien");
        }

        public DataTable LayChiTietGiangVien(string maGV)
        {
            string query = $@"SELECT G.HoTen, K.TenKhoa, G.SoDienThoai 
                             FROM GiangVien G 
                             JOIN KhoaVien K ON G.MaKhoa = K.MaKhoa 
                             WHERE G.MaGV = '{maGV}'";
            return kn.ExecuteQuery(query);
        }

        public bool KiemTraTrungLich(string maPhong, DateTime ngayDat, int caHoc)
        {
            string ngay = ngayDat.ToString("yyyy-MM-dd");
            string query = $"SELECT COUNT(*) FROM LichDatPhong WHERE MaPhong = '{maPhong}' AND NgayDat = '{ngay}' AND CaHoc = {caHoc} AND TrangThaiDuyet != N'Từ chối'";
            DataTable dt = kn.ExecuteQuery(query);
            return dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }

        public bool ThemDatPhong(LichDatPhongDTO dto)
        {
            string query = $@"INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) 
                              VALUES ('{dto.MaPhong}', '{dto.MaGV}', '{dto.NgayDat:yyyy-MM-dd}', {dto.CaHoc}, {dto.TietBatDau}, {dto.TietKetThuc}, N'{dto.MucDich}', N'{dto.TrangThaiDuyet}')";
            return kn.ExecuteNonQuery(query);
        }
    }
}