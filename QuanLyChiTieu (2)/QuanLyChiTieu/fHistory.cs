using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace QuanLyChiTieu
{
    public partial class fHistory : Form
    {
        public fHistory()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ufromDate = dtFromDate.Value;
                DateTime utoDate = dtToDate.Value;
                string FromDate = ufromDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
                string ToDate = utoDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    string query = "SELECT TenCT, SoTien, DMCT, NgayChi FROM ChiTieu INNER JOIN TaiKhoan ON TaiKhoan.MaTK = ChiTieu.MaCT WHERE NgayChi BETWEEN @FromDate AND @ToDate";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);

                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            GridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

