using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace QuanLyChiTieu
{
    public partial class fHistory : Form
    {
        Modify modify = new Modify();
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
                int userID = modify.GetCurrentUser();
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    string query = "SELECT TenCT as [Tên chi tiêu], SoTien as [Số tiền], DMCT as [Danh mục], NgayChi as [Ngày chi], GhiChu as [Ghi chú] FROM ChiTieu WHERE NgayChi BETWEEN @FromDate AND @ToDate AND ChiTieu.MaCT = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FromDate", FromDate);
                        command.Parameters.AddWithValue("@ToDate", ToDate);
                        command.Parameters.AddWithValue("@UserID", userID);

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

        private void fHistory_Load(object sender, EventArgs e)
        {

        }
    }

}

