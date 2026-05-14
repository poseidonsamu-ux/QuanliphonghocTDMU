using System;
using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class BaoCaoSuCoDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        // 1. Giảng viên gửi báo cáo
        public bool GuiBaoCao(string maPhong, string maGV, string loaiSuCo, string moTa, int mucDo)
        {
            string sql = $@"INSERT INTO BaoCaoSuCo (MaPhong, MaGV, LoaiSuCo, MoTa, MucDo, TrangThai) 
                            VALUES ('{maPhong}', '{maGV}', N'{loaiSuCo}', N'{moTa}', {mucDo}, N'Chờ xử lý')";
            return kn.ExecuteNonQuery(sql);
        }

        // 2. Thuật toán AI - Gợi ý phòng thay thế
        public DataTable SuggestPhongThayThe(string maPhongGoc, DateTime ngay, int ca)
        {
            string ngayStr = ngay.ToString("yyyy-MM-dd");
            string sql = $@"
                DECLARE @ToaGoc VARCHAR(10) = (SELECT MaToaNha FROM PhongHoc WHERE MaPhong = '{maPhongGoc}');
                DECLARE @TangGoc NVARCHAR(20) = (SELECT Tang FROM PhongHoc WHERE MaPhong = '{maPhongGoc}');
                DECLARE @SucChuaGoc INT = (SELECT SucChua FROM PhongHoc WHERE MaPhong = '{maPhongGoc}');

                SELECT TOP 5 p.MaPhong, p.MaToaNha, 
                       (CASE WHEN p.MaToaNha = @ToaGoc THEN 20 ELSE 0 END +
                        CASE WHEN p.Tang = @TangGoc THEN 15 ELSE 0 END +
                        CASE WHEN p.SucChua >= @SucChuaGoc THEN 10 ELSE 0 END) AS DiemPhuHop
                FROM PhongHoc p
                WHERE p.MaPhong != '{maPhongGoc}'
                  AND NOT EXISTS (
                      SELECT 1 FROM LichDatPhong ld 
                      WHERE ld.MaPhong = p.MaPhong AND ld.NgayDat = '{ngayStr}' AND ld.CaHoc = {ca} AND ld.TrangThaiDuyet = N'Đã duyệt'
                  )
                ORDER BY DiemPhuHop DESC, NEWID()"; // Trộn ngẫu nhiên nếu điểm bằng nhau
            return kn.ExecuteQuery(sql);
        }

        // 3. ADMIN - Thống kê Dashboard
        public DataTable GetThongKe()
        {
            string sql = @"
                SELECT 
                    COUNT(*) AS TongSuCo,
                    SUM(CASE WHEN TrangThai = N'Chờ xử lý' THEN 1 ELSE 0 END) AS DangXuLy,
                    SUM(CASE WHEN TrangThai = N'Đã xử lý' THEN 1 ELSE 0 END) AS DaXuLy
                FROM BaoCaoSuCo";
            return kn.ExecuteQuery(sql);
        }

        // 4. ADMIN - Lấy danh sách để quản lý
        public DataTable GetDanhSachSuCo()
        {
            string sql = @"
                SELECT bc.MaSuCo AS [ID], bc.MaPhong AS [Phòng], gv.HoTen AS [Giảng viên], 
                       bc.LoaiSuCo AS [Loại sự cố], bc.MoTa AS [Mô tả], bc.MucDo AS [Mức độ], 
                       bc.TrangThai AS [Trạng thái], bc.NgayBaoCao AS [Ngày báo cáo]
                FROM BaoCaoSuCo bc LEFT JOIN GiangVien gv ON bc.MaGV = gv.MaGV
                ORDER BY bc.TrangThai ASC, bc.MucDo DESC, bc.NgayBaoCao DESC";
            return kn.ExecuteQuery(sql);
        }

        // 5. ADMIN - Xác nhận đã sửa xong
        public bool XacNhanXuLy(int id)
        {
            return kn.ExecuteNonQuery($"UPDATE BaoCaoSuCo SET TrangThai = N'Đã xử lý' WHERE MaSuCo = {id}");
        }
    }
}