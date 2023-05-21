using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fQuanLyChiTieu : Form
    {
        
        Modify modify = new Modify();
        string username = fDangNhap.namesend;

        public fQuanLyChiTieu()
        {
            InitializeComponent();
        }
        private void fQuanLyChiTieu_Load(object sender, EventArgs e)
        {
            DateTime fromDate = DateTime.Now.AddDays(-30);
            string fromDateStr = fromDate.ToString("yyyy-MM-dd");

            DateTime toDate = DateTime.Now;
            string toDateStr = toDate.ToString("yyyy-MM-dd");
            int userID = modify.GetCurrentUser();
            string OutComeQuery = "SELECT SUM(SoTien) FROM ChiTieu WHERE NgayChi BETWEEN '" + fromDateStr + "' AND '" + toDateStr + "' AND MaCT = '" + userID + "'";

            string InComeQuery = "SELECT SUM(SoTien) FROM ThuNhap WHERE NgayThu BETWEEN '" + fromDateStr + "' AND '" + toDateStr + "' AND MaTN = '" + userID + "'";

            double sumOut = modify.SumOutcome_Income(OutComeQuery);
            double sumInt = modify.SumOutcome_Income(InComeQuery);
            string greeting = username;
            label10.Text = greeting;
            label4.Text = sumInt.ToString();
            label7.Text = sumOut.ToString();
            ReloadData();
            MessageBox.Show("Chào mừng bạn đã trở lại " + username);
            fillchart();
            SumTien();
        }
        private void ReloadData()
        {
            try
            {
                string query = "SELECT TenCT, SoTien, NgayChi FROM ChiTieu WHERE MaCT = @UserID";
                DataTable dataTable = modify.LoadData(query);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnreload_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
                ReloadData();
                
        }
        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            
            fThemChiTieu themchitieu = new fThemChiTieu();
            themchitieu.ShowDialog();
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            fHistory fHistory = new fHistory();
            fHistory.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            fthunhap fthunhap = new fthunhap();
            fthunhap.ShowDialog();
        }
        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Groupinfo groupinfo = new Groupinfo();
            groupinfo.ShowDialog();
        }
        private void fillchart()
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    DataTable dt = new DataTable();
                    connection.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT ID,TongTien FROM THONGKE", connection);
                    da.Fill(dt);
                    chart1.DataSource = dt;
                    connection.Close();

                    chart1.Series["Money"].XValueMember = "ID";
                    chart1.Series["Money"].YValueMembers = "TongTien";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SumTien()
        {
            try
            {
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();
                    int userID = modify.GetCurrentUser();
                    for (int month = 1; month <= 12; month++)
                    {
                        string query = "SELECT Sum(SoTien)  FROM ChiTieu WHERE Thang = @month AND MaCT = @userID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@userID", userID);
                        object sumValue = command.ExecuteScalar();

                        string updateQuery = "UPDATE THONGKE SET TongTien = @sumValue WHERE ID = @month";
                        command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@month", month);
                        command.Parameters.AddWithValue("@sumValue", sumValue);
                        command.ExecuteNonQuery();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void bunifuPanel7_Click(object sender, EventArgs e)
        {

        }
        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }
    
    }
}

