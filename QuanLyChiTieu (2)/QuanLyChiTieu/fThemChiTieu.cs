using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        DataTable tb = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public fThemChiTieu()
        {
            InitializeComponent();
        }
        
        
        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void fThemChiTieu_Load(object sender, EventArgs e)
        {
            string query = "SELECT ChiTieu.TenCT, ChiTieu.DMCT, ChiTieu.SoTien, ChiTieu.SoLuong, ChiTieu.GhiChu FROM ChiTieu INNER JOIN TaiKhoan ON TaiKhoan.MaTK = ChiTieu.MaCT WHERE ChiTieu.MaCT = TaiKhoan.MaTK";
            DataTable dataTable = modify.GetData(query);
            dgvThongtin.DataSource = dataTable;
        }


        private void DisplayData()
        {

            dgvThongtin.Columns["TenChiTieu"].HeaderText = "Tên chi tiêu";
            dgvThongtin.Columns["DMCT"].HeaderText = "Danh mục";
            dgvThongtin.Columns["SoTien"].HeaderText = "Số Tiền";
            dgvThongtin.Columns["SL"].HeaderText = "Số lượng";
            dgvThongtin.Columns["GhiChu"].HeaderText = "Ghi Chú";

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
                /*try
                {
                    int.Parse(txtTien.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng không nhập ký tự vào số tiền!", "Thông Báo!");
                    return;
                }*/

                int SL = int.Parse(txtSL.Text);
                float Cost = float.Parse(txtTien.Text);
                Cost = Cost * SL;

                string tenCT = txtTen.Text;
                string DMCT = txtDM.Text;
                float Sotien = Cost;
                string SoLG = txtSL.Text;
                string Note = txtGC.Text;

                string query = "INSERT INTO ChiTieu (MaCT, TenCT, DMCT, SoTien, SoLuong, GhiChu) SELECT MaTK, '" + tenCT + "', '" + DMCT + "', '" + Sotien + "', '" + SoLG + "', '" + Note + "' FROM TaiKhoan";
                modify.Command(query);
                
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        //chưa hoàn thiện
        public double sumCost()
        {
            ChiTieuCaNhan chiTieu = new ChiTieuCaNhan();
            
            int SL = int.Parse(txtSL.Text);
            double Cost = double.Parse(txtTien.Text);
            Cost = Cost * SL;
            
            double sumCost = double.Parse(chiTieu.SoTien);
            
            return 0;
        }
        private void btnxoainfo_Click(object sender, EventArgs e)
        {
           
           /* if (dgvThongtin.CurrentRow != null)
            {
                int selectedIndex = dgvThongtin.CurrentRow.Index;
                chiTieuList.RemoveAt(selectedIndex);
                DisplayData();
            }*/
        }

        private void btndeldanhmuc_Click(object sender, EventArgs e)
        {
            if (txtDM.SelectedItem != null)
            {
                   string selectedDanhMuc = txtDM.SelectedItem.ToString();
                   txtDM.Items.Remove(selectedDanhMuc);
            }
        }
        

        private void btnadddanhmuc_Click(object sender, EventArgs e)
        {
            txtDM.Items.Add(txtDM.Text);
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
