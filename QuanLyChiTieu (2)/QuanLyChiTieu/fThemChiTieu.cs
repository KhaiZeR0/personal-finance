using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
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
            string query = "SELECT STT_CT, TenCT AS [Tên chi tiêu], DMCT AS [Danh mục], SoTien AS [Số tiền], SoLuong AS [Số lượng], NgayChi AS [Ngày chi], GhiChu AS [Ghi chú] FROM ChiTieu WHERE MaCT = @UserID";
            DataTable dataTable = modify.LoadData(query);

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

                int userID = modify.GetCurrentUser();
                string OutComeQuery = "SELECT SUM(SoTien) FROM ChiTieu WHERE MaCT = '" + userID + "'";
                string InComeQuery = "SELECT SUM(SoTien) FROM ThuNhap WHERE MaTN = '" + userID + "'";

                double sumOut = modify.SumOutcome_Income(OutComeQuery);
                double sumIn = modify.SumOutcome_Income(InComeQuery);           

                sumOut = sumOut + Cost;
                if (sumOut > sumIn)
                {
                    MessageBox.Show("Số tiền chi tiêu của bạn không được vượt quá mức số tiền thu nhập", "Thông báo!");return;
                }
                
                DateTime toDate = DateTime.Now.AddDays(-30);
                string NgayChi = toDate.ToString("yyyy-MM-dd");
                DateTime currentMonth = DateTime.Now;
                string Thang = currentMonth.ToString("MM");

                string tenCT = txtTen.Text;
                string DMCT = txtDM.Text;
                string SoLG = txtSL.Text;
                string Note = txtGC.Text;
        
                int UserID = modify.GetCurrentUser();
                string query = "INSERT INTO ChiTieu(TenCT, DMCT, SoTien, SoLuong, GhiChu, NgayChi, Thang, MaCT) VALUES (@TenCT, @DMCT, @SoTien, @SoLuong, @GhiChu, @NgayChi, @Thang, @UserID)";

                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenCT", tenCT);
                        command.Parameters.AddWithValue("@DMCT", DMCT);
                        command.Parameters.AddWithValue("@SoTien", Cost);
                        command.Parameters.AddWithValue("@SoLuong", SoLG);
                        command.Parameters.AddWithValue("@GhiChu", Note);
                        command.Parameters.AddWithValue("@NgayChi", NgayChi);
                        command.Parameters.AddWithValue("@Thang", Thang);
                        command.Parameters.AddWithValue("@UserID", UserID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
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
                        }
                    }
                    ReloadData();
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
