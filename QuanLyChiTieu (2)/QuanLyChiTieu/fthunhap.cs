using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fthunhap : Form
    {
        
        Modify modify = new Modify();
        public fthunhap()
        {
            InitializeComponent();
        }
        private void fthunhap_Load(object sender, EventArgs e)
        {
            ReloadData();
        }
        private void ReloadData()
        {
            string query = "SELECT STT_TN, SoTien, NgayThu, GhiChu FROM ThuNhap WHERE MaTN = @UserID";
            DataTable dataTable = modify.LoadData(query);

            dgvLichSuThuNhap.DataSource = dataTable;
            dgvLichSuThuNhap.Columns["STT_TN"].Visible = false;
        }

        private void btnSaveThuNhap_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtThuNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống số tiền!", "Thông Báo!");
                    return;
                }

                double Sotien = double.Parse(txtThuNhap.Text);
                string Note = txtGhiChu.Text;
                int UserID = modify.GetCurrentUser();

                DateTime currentDate = DateTime.Now;
                string NgayThu = currentDate.ToString("yyyy-MM-dd HH:mm:ss");

                string query = "INSERT INTO ThuNhap (MaTN, SoTien, GhiChu, NgayThu) VALUES ( '" + UserID + "', '" + Sotien + "', N'" + Note + "', '" + NgayThu + "')";
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
            if (dgvLichSuThuNhap.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvLichSuThuNhap.SelectedRows[0].Index;
                    int sttTN = Convert.ToInt32(dgvLichSuThuNhap.Rows[selectedRowIndex].Cells["STT_TN"].Value);

                    string deleteQuery = "DELETE FROM ThuNhap WHERE STT_TN = @STT_TN";
                    using (SqlConnection connection = Connection.GetSqlConnection())
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@STT_TN", sttTN);
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
       
        private void txtThuNhap_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnSaveThuNhap_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuPanel4_Click(object sender, EventArgs e)
        {

        }
        
    }
}
