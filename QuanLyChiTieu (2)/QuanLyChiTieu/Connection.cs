using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
