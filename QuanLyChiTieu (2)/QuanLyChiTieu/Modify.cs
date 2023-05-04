using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyChiTieu
{
     internal class Modify
    {
        public Modify()
        {
        }

        SqlCommand sqlCommand; //dung để truy vấn các câu lệnh
        SqlDataReader DataReader; //dung để đọc dữ liệu trong database

        public List<TaiKhoan> TaiKhoans(string query) //dùng để kiểm tra tài khoản
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                DataReader = sqlCommand.ExecuteReader();
                while (DataReader.Read())
                {
                    taiKhoans.Add(new TaiKhoan(DataReader.GetString(0), DataReader.GetString(1)));
                }

                sqlConnection.Close();
            }
                return taiKhoans;
        }
         //dùng để đăng ký tài khoản
        public void Command(string query) 
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }    
        }
     }
}
