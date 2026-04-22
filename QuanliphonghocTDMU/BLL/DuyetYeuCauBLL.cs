using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class DuyetYeuCauBLL
    {
        DuyetYeuCauDAL dal = new DuyetYeuCauDAL();

        public DataTable LayDanhSach()
        {
            return dal.LayDanhSachChoDuyet();
        }

        public bool DuyetYeuCau(string maDat)
        {
            if (string.IsNullOrEmpty(maDat)) return false;
            return dal.CapNhatTrangThai(maDat, "Đã duyệt");
        }

        public bool TuChoiYeuCau(string maDat)
        {
            if (string.IsNullOrEmpty(maDat)) return false;
            return dal.CapNhatTrangThai(maDat, "Từ chối");
        }
    }
}