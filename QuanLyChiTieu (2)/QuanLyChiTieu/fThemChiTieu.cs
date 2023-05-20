using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fThemChiTieu : Form
    { 
        Modify modify = new Modify();
        public fThemChiTieu()
        {
            InitializeComponent();
        }
        private void fThemChiTieu_Load(object sender, EventArgs e)
        {
            if(dgvThongtin != null)
            ReloadData();
        }

        private void ReloadData()
        {
            int UserID = Modify.UserID;
            string query = "SELECT STT_CT, TenCT, DMCT, SoTien, SoLuong, NgayChi, GhiChu FROM ChiTieu INNER JOIN TaiKhoan ON TaiKhoan.MaTK = ChiTieu.MaCT WHERE TaiKhoan.MaTK = '" + UserID + "'";
            DataTable dataTable = new DataTable();
            dataTable.Clear();

            dataTable = modify.GetData(query);


            dgvThongtin.DataSource = dataTable;
            dgvThongtin.Columns["STT_CT"].Visible = false;
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
                double Cost = double.Parse(txtTien.Text);
                Cost = Cost * SL;

                string tenCT = txtTen.Text;
                var DMCT = txtDM.Text;
                double Sotien = Cost;
                string SoLG = txtSL.Text;
                string Note = txtGC.Text;
             
                DateTime currentDate = DateTime.Now;
                string NgayChi = currentDate.ToString("yyyy-MM-dd");

                string query = "INSERT INTO ChiTieu (MaCT, TenCT, DMCT, SoTien, SoLuong, GhiChu, NgayChi) SELECT MaTK, N'" + tenCT + "', N'" + DMCT + "', '" + Sotien + "', '" + SoLG + "', N'" + Note + "', '" + NgayChi + "' FROM TaiKhoan";
                modify.Command(query);
                ReloadData();
            }   
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }
        private void btnxoainfo_Click(object sender, EventArgs e)
        {
            if (dgvThongtin.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvThongtin.SelectedRows[0].Index;
                    int sttCT = Convert.ToInt32(dgvThongtin.Rows[selectedRowIndex].Cells["STT_CT"].Value);

                    string deleteQuery = "DELETE FROM ChiTieu WHERE STT_CT = @STT_CT";
                    using (SqlConnection connection = Connection.GetSqlConnection())
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@STT_CT", sttCT);
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Xóa dữ liệu thành công!");
                            ReloadData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu để xóa!", "Thông báo");
            }
        }
        private void btnadddanhmuc_Click(object sender, EventArgs e)
        {
            txtDM.Items.Add(txtDM.Text);
        }
        //cần fix lại thành xóa danh mục "được chọn"
        private void btndeldanhmuc_Click(object sender, EventArgs e)
        {
            if (txtDM.SelectedItem != null)
            {
                   string selectedDanhMuc = txtDM.SelectedItem.ToString();
                   txtDM.Items.Remove(selectedDanhMuc);
            }
        }
        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        }
        private void dgvThongtin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
