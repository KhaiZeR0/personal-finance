using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyChiTieu
{
    public partial class fThemChiTieu : Form
    {
        List<ChiTieuCaNhan> chiTieuList = new List<ChiTieuCaNhan>();
        public fThemChiTieu()
        {
            InitializeComponent();
        }
        
        
        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayData()
        {
            dgvThongtin.DataSource = null;
            dgvThongtin.DataSource = chiTieuList;

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
                try
                {
                    int.Parse(txtTien.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng không nhập ký tự vào số tiền!", "Thông Báo!");
                    return;
                }

                int SL = int.Parse(txtSL.Text);
                double Cost = double.Parse(txtTien.Text);
                Cost = Cost * SL;

                ChiTieuCaNhan chiTieu = new ChiTieuCaNhan();




                chiTieu.TenChiTieu = txtTen.Text;

                chiTieu.DMCT = txtDM.Text;

                chiTieu.SoTien = Cost.ToString();

                chiTieu.SL = txtSL.Text;

                chiTieu.GhiChu = txtGC.Text;

                chiTieuList.Add(chiTieu);

                DisplayData();

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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void fThemChiTieu_Load(object sender, EventArgs e)
        {
           
        }

        private void btnxoainfo_Click(object sender, EventArgs e)
        {
            if (dgvThongtin.CurrentRow != null)
            {
                dgvThongtin.Rows.Remove(dgvThongtin.CurrentRow);
            }
        }

        private void btndeldanhmuc_Click(object sender, EventArgs e)
        {
            txtDM.Items.RemoveAt(0);
        }

        private void btnadddanhmuc_Click(object sender, EventArgs e)
        {
            txtDM.Items.Add(txtDM.Text);
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
