using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.DAL
{
    public class TrangChuDAL
    {
        // Chuỗi kết nối CSDL
        private string chuoiKetNoi = @"Data Source=.;Initial Catalog=QLPhongHoc_TDMU;Integrated Security=True";

        // Hàm lấy 5 yêu cầu đặt phòng mới nhất
        public List<YeuCauMoiNhatDTO> LayYeuCauMoiNhat()
        {
            List<YeuCauMoiNhatDTO> dsYeuCau = new List<YeuCauMoiNhatDTO>();

            string query = @"
                SELECT TOP 5 
                    L.MaPhong, 
                    G.HoTen, 
                    CONVERT(VARCHAR(10), L.NgayDat, 103) + N' (Tiết ' + CAST(L.TietBatDau AS VARCHAR) + '-' + CAST(L.TietKetThuc AS VARCHAR) + ')' + '' AS 'ThoiGian'
                FROM LichDatPhong L
                JOIN GiangVien G ON L.MaGV = G.MaGV
                ORDER BY L.MaDatPhong DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            YeuCauMoiNhatDTO dto = new YeuCauMoiNhatDTO();
                            dto.Phong = reader["MaPhong"].ToString();
                            dto.GiangVien = reader["HoTen"].ToString();
                            dto.ThoiGian = reader["ThoiGian"].ToString();
                            dsYeuCau.Add(dto);
                        }
                    }
                }
            }
            return dsYeuCau;
        }

        // Hàm lấy 5 sự cố thiết bị cần xử lý gấp
        public List<SuCoKhanCapDTO> LaySuCoKhanCap()
        {
            List<SuCoKhanCapDTO> dsSuCo = new List<SuCoKhanCapDTO>();

            string query = @"
                SELECT TOP 5
                    MaPhong,
                    MoTa,
                    TrangThai
                FROM BaoCaoSuCo
                WHERE TrangThai IN (N'Chưa xử lý', N'Đang xử lý')
                ORDER BY MaSuCo DESC";

            using (SqlConnection conn = new SqlConnection(chuoiKetNoi))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SuCoKhanCapDTO dto = new SuCoKhanCapDTO();
                            dto.Phong = reader["MaPhong"].ToString();
                            dto.SuCo = reader["MoTa"].ToString();
                            dto.MucDo = reader["TrangThai"].ToString();
                            dsSuCo.Add(dto);
                        }
                    }
                }
            }
            return dsSuCo;
        }
    }
}