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
            string query = "SELECT MaPhong, SucChua FROM PhongHoc WHERE TrangThai = N'Sẵn sàng'";
            return kn.ExecuteQuery(query);
        }

        public DataTable LayDanhSachGiangVien()
        {
            string query = "SELECT MaGV, HoTen FROM GiangVien";
            return kn.ExecuteQuery(query);
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
            if (dt.Rows.Count > 0 && Convert.ToInt32(dt.Rows[0][0]) > 0)
            {
                return true;
            }
            return false;
        }

        public bool ThemDatPhong(LichDatPhongDTO dto)
        {
            string mucDich = string.IsNullOrEmpty(dto.MucDich) ? "" : dto.MucDich.Replace("'", "''");
            string maPhong = dto.MaPhong.Replace("'", "''");
            string maGV = dto.MaGV.Replace("'", "''");
            string ngayDat = dto.NgayDat.ToString("yyyy-MM-dd");

            string query = $@"INSERT INTO LichDatPhong (MaPhong, MaGV, NgayDat, CaHoc, TietBatDau, TietKetThuc, MucDich, TrangThaiDuyet) 
                              VALUES ('{maPhong}', '{maGV}', '{ngayDat}', {dto.CaHoc}, {dto.TietBatDau}, {dto.TietKetThuc}, N'{mucDich}', N'{dto.TrangThaiDuyet}')";
            return kn.ExecuteNonQuery(query);
        }
    }
}