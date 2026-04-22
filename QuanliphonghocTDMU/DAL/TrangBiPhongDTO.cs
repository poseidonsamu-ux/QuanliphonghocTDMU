namespace QuanLiPhongHocTDMU.DTO
{
    public class TrangBiPhongDTO
    {
        public string MaPhong { get; set; }
        public string MaTB { get; set; }
        public string TenTB { get; set; } // Lấy từ bảng ThietBi qua JOIN
        public int SoLuong { get; set; }
        public string TinhTrang { get; set; }
    }
}