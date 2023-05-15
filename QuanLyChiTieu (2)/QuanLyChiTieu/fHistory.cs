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
                using(SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using (DataTable dt = new DataTable("Order"))
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM ChiTieu WHERE NgayChi >= dtFromDate AND NgayChi <= dtToDate", cn))
                        {
                            cmd.Parameters.AddWithValue("@Ngaychi", dtFromDate.Value);
                            cmd.Parameters.AddWithValue("@Ngaychi", dtToDate.Value);
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                            sqlDataAdapter.Fill(dt);
                            GridView.DataSource = dt;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messenger",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
