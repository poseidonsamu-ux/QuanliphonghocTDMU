using System.Data;
using QuanLiPhongHocTDMU.DAL;

namespace QuanLiPhongHocTDMU.BLL
{
    public class TrangChuBLL
    {
        TrangChuDAL dal = new TrangChuDAL();

        public DataTable TaiThongKe()
        {
            return dal.LayThongKe();
        }

        public DataTable TaiLichDay(string maGV)
        {
            return dal.LayLichDayGV(maGV);
        }
    }
}