using System.Data.SqlClient;

namespace QuanLyChiTieu
{
     class Connection
     {
        private static string stringConnection = @"Data Source=DESKTOP-EEVRIBE\SQLEXPRESS;Initial Catalog=QuanLyChiTieu;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }

}
