using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyChiTieu
{
    public partial class fThemChiTieu : Form
    { 
        Modify modify = new Modify();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        public fThemChiTieu()
        {
            InitializeComponent();
        }
        
        
        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fThemChiTieu_Load(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void ReloadData()
        {
            string query = "SELECT ChiTieu.TenCT, ChiTieu.DMCT, ChiTieu.SoTien, ChiTieu.SoLuong, ChiTieu.GhiChu FROM ChiTieu INNER JOIN TaiKhoan ON TaiKhoan.MaTK = ChiTieu.MaCT WHERE ChiTieu.MaCT = TaiKhoan.MaTK";
            /*DataTable dataTable = new DataTable();*/
            dataTable = modify.GetData(query);
            dgvThongtin.DataSource = dataTable;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDM.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống danh mục!", "Thông Báo!");
                    return;
                }
                else if (txtTien.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống số tiền!", "Thông Báo!");
                    return;
                }
                else if (txtSL.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống số lượng!", "Thông Báo!");
                    return;
                }

                int SL = int.Parse(txtSL.Text);
                float Cost = float.Parse(txtTien.Text);
                Cost = Cost * SL;

                string tenCT = txtTen.Text;
                var DMCT = txtDM.Text;
                double Sotien = Cost;
                string SoLG = txtSL.Text;
                string Note = txtGC.Text;
                Random rand = new Random();
                string randomID = (rand.Next(999999)).ToString();

                DateTime currentDate = DateTime.Now;
                string NgayChi = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

                string query = "INSERT INTO ChiTieu (MaCT, TenCT, DMCT, SoTien, SoLuong, GhiChu, NgayChi,IdDelete) SELECT MaTK, '" + tenCT + "', '" + DMCT + "', '" + Sotien + "', '" + SoLG + "', '" + Note + "', '" + NgayChi + "', '" + randomID + "' FROM TaiKhoan";
                modify.Command(query);
                ReloadData();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        private void dgvThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnxoainfo_Click(object sender, EventArgs e)
        {
         using (SqlConnection connection = Connection.GetSqlConnection())
            {
                string deleteQuery = "DELETE FROM ChiTieu WHERE ID = @STT_CT";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@STT_CT", ID);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Deleted Successfully!");
                    ReloadData();

                }
            }
        }

        private void btnadddanhmuc_Click(object sender, EventArgs e)
        {
            txtDM.Items.Add(txtDM.Text);
        }
        private void btndeldanhmuc_Click(object sender, EventArgs e)
        {
            if (txtDM.SelectedItem != null)
            {
                   string selectedDanhMuc = txtDM.SelectedItem.ToString();
                   txtDM.Items.Remove(selectedDanhMuc);
            }
        }
        

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtGC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThongtin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThongtin_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_State.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
