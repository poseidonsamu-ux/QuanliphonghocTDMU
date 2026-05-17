using System;
using System.Collections.Generic;
using QuanLiPhongHocTDMU.DAL;
using QuanLiPhongHocTDMU.DTO;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TrangChuBLL
    {
        private TrangChuDAL dalTrangChu = new TrangChuDAL();

        // Gọi sang DAL để lấy danh sách yêu cầu mới nhất
        public List<YeuCauMoiNhatDTO> LayYeuCauMoiNhat()
        {
            return dalTrangChu.LayYeuCauMoiNhat();
        }

        // Gọi sang DAL để lấy danh sách sự cố 
        public List<SuCoKhanCapDTO> LaySuCoKhanCap()
        {
            return dalTrangChu.LaySuCoKhanCap();
        }
    }
}