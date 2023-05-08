using System;
using System.Collections.Generic;
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
        private static string GenerateHash(string toHash)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(toHash));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
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
