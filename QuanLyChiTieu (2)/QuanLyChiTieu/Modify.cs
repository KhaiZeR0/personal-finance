using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace QuanLyChiTieu
{
    internal class Modify
    {
        private SqlCommand sqlCommand;
        private SqlDataReader sqlDataReader;

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
    }
}
