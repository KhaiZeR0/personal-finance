using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

    
namespace QuanLyChiTieu
{
    internal class Modify
    {
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;
        string username = fDangNhap.namesend;
        public static int UserID;

        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);

                sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string tenTaiKhoan = sqlDataReader.GetValue(0).ToString();
                    string matKhau = sqlDataReader.GetValue(1).ToString();


                    TaiKhoan taiKhoan = new TaiKhoan(tenTaiKhoan, matKhau);
                    taiKhoans.Add(taiKhoan);
                }
                sqlDataReader.Close();
            }
            return taiKhoans;
        }
        public DataTable GetData(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public int GetCurrentUser()
        {
            int user = 0;
            string query = "SELECT MaTK FROM TaiKhoan WHERE TenTK = @TenTK";
            string tenTaiKhoan = username;
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand(query, sqlConnection))
                {
                    command.Parameters.AddWithValue("@TenTK", tenTaiKhoan);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = reader.GetInt32(0);
                        }
                    }
                }
            }
            user = UserID;
            return user;
        }
    }
}
