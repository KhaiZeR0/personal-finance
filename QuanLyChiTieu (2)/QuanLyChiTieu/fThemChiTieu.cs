using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            // Ẩn cột "IdDelete"
            dgvThongtin.Columns["IdDelete"].Visible = false;

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
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy giá trị của cột "IdDelete" từ dòng được chọn
                    string idDelete = dgvThongtin.Rows[e.RowIndex].Cells["IdDelete"].Value.ToString();

                    // Thực hiện lệnh xóa dựa trên giá trị "IdDelete"
                    string query = "DELETE FROM ChiTieu WHERE IdDelete = '" + idDelete + "'";
                    modify.Command(query);

                    // Tải lại dữ liệu
                    ReloadData();
                }
            

        }
        private void btnxoainfo_Click(object sender, EventArgs e)
        {
            /*try
            {
                if (dgvThongtin.SelectedRows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiêu đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dgvThongtin.SelectedRows)
                        {
                            int stt = Convert.ToInt32(row.Cells["STT_CT"].Value);
                            string query = "DELETE FROM ChiTieu WHERE STT_CT = '" + stt + "'";
                            modify.Command(query);
                        }
                        ReloadData();
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn dữ liệu để xóa!", "Thông báo");
            }*/
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

        
    }
}
