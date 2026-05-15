using System;
using System.Data;

namespace QuanLiPhongHocTDMU.DAL
{
    public class ThongKeSuCoDAL
    {
        KetNoiCSDL kn = new KetNoiCSDL();

        // Lấy toàn bộ danh sách sự cố để đổ vào DataGridView và xuất Excel
        public DataTable LayBangThongKe()
        {
            string sql = @"
                SELECT bc.MaSuCo AS [Mã ID], 
                       bc.MaPhong AS [Phòng Học], 
                       gv.HoTen AS [Người Báo Cáo], 
                       bc.LoaiSuCo AS [Loại Sự Cố], 
                       bc.MoTa AS [Mô Tả Chi Tiết], 
                       bc.MucDo AS [Mức Độ], 
                       bc.TrangThai AS [Trạng Thái], 
                       bc.NgayBaoCao AS [Ngày Báo Cáo]
                FROM BaoCaoSuCo bc 
                LEFT JOIN GiangVien gv ON bc.MaGV = gv.MaGV
                ORDER BY bc.TrangThai ASC, bc.NgayBaoCao DESC";
            return kn.ExecuteQuery(sql);
        }
    }
}