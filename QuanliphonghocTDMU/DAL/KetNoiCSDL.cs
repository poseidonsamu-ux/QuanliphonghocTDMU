using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace QuanLiPhongHocTDMU.DAL
{
    public class KetNoiCSDL
    {
        // Đọc chuỗi kết nối từ file App.config thông qua tên "ChuoiKetNoiTDMU"
        private string strConnect = ConfigurationManager.ConnectionStrings["ChuoiKetNoiTDMU"].ConnectionString;

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
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
            return data;
        }

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
                MessageBox.Show("Lỗi thực thi CSDL: " + ex.Message);
                return false;
            }
        }
    }
}