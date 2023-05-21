using System;
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
        
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public DataTable LoadData(string query)
        {
            int userID = GetCurrentUser();
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@UserID", userID);

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }
        public double SumOutcome_Income(string query)
        {
            double tempSum = 0 ;

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand sum = new SqlCommand(query, connection))
                {
                    object SumResult = sum.ExecuteScalar();
                    if (SumResult != DBNull.Value)
                    {
                        tempSum = Convert.ToDouble(SumResult);
                    }
                }
            }
            return tempSum;
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
                           user  = reader.GetInt32(0);
                        }
                    }
                }
            }
            return user;
        }
    }
}
