using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiPhongHocTDMU
{
    public class KetNoiCSDL
    {
        // Chuỗi kết nối chính chủ máy của bạn
        private string strConnect = @"Data Source=LAPTOP-DG7E8GEE;Initial Catalog=QLPhongHoc_TDMU;Integrated Security=True";

        // Hàm 1: Chạy lệnh SELECT (Lấy dữ liệu)
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnect))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
            return data;
        }

        // Hàm 2: Chạy lệnh INSERT, UPDATE, DELETE (Thêm, Sửa, Xóa)
        public bool ExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(strConnect))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    int result = command.ExecuteNonQuery();
                    connection.Close();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi thực thi CSDL: " + ex.Message);
                return false;
            }
        }
    }
}