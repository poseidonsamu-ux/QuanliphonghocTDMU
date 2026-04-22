using System;

namespace QuanLiPhongHocTDMU.DTO
{
    public class LichDatPhongDTO
    {
        public int MaDatPhong { get; set; }
        public string MaPhong { get; set; }
        public string MaGV { get; set; }
        public DateTime NgayDat { get; set; }
        public string CaHoc { get; set; }

        public int TietBatDau { get; set; }
        public int TietKetThuc { get; set; }

        public string MucDich { get; set; }
        public string TrangThaiDuyet { get; set; }
    }
}