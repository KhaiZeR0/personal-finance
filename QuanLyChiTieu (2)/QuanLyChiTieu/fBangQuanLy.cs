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
            ReloadData();
            MessageBox.Show("Chào mừng bạn đã trở lại " + username);
            string query = "SELECT ";
            string greeting = username;
            label10.Text = greeting;
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

        private void btnreload_Click(object sender, EventArgs e)
        {
            if(dataGridView1 != null)
            ReloadData();
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

