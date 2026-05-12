using System;
using System.Collections.Generic;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TrangChuBLL
    {
        private TrangChuDAL dalTrangChu = new TrangChuDAL();

        // Gọi sang DAL để lấy danh sách yêu cầu mới nhất (đã map vào DTO)
        public List<YeuCauMoiNhatDTO> LayYeuCauMoiNhat()
        {
            return dalTrangChu.LayYeuCauMoiNhat();
        }

        // Gọi sang DAL để lấy danh sách sự cố (đã map vào DTO)
        public List<SuCoKhanCapDTO> LaySuCoKhanCap()
        {
            return dalTrangChu.LaySuCoKhanCap();
        }
    }
}