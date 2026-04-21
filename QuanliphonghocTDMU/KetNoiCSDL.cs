using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLiPhongHocTDMU
{
    public class KetNoiCSDL
    {
        private string strConnect = @"Data Source=LAPTOP-DG7E8GEE;Initial Catalog=QLPhongHoc_TDMU;Integrated Security=True";

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