using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fthunhap : Form
    {
        List<Thunhapcanhan> thuNhapList = new List<Thunhapcanhan>();
        Modify modify = new Modify();
        SqlDataAdapter adapter = new SqlDataAdapter();
        public fthunhap()
        {
            InitializeComponent();
        }

        private void txtThuNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayData()
        {
            dgvLichSuThuNhap.DataSource = null;
            dgvLichSuThuNhap.DataSource = thuNhapList;

            dgvLichSuThuNhap.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvLichSuThuNhap.Columns["SoTien"].HeaderText = "Số Tiền";
        }

        private void btnSaveThuNhap_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuPanel4_Click(object sender, EventArgs e)
        {

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

                Thunhapcanhan thuNhap = new Thunhapcanhan();

                thuNhap.SoTien = txtThuNhap.Text;

                thuNhap.GhiChu = txtGhiChu.Text;

                thuNhapList.Add(thuNhap);

                DisplayData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString());
            }
        }

        private void fthunhap_Load(object sender, EventArgs e)
        {

        }

        private void btnxoainfo_Click(object sender, EventArgs e)
        {
            if (dgvLichSuThuNhap.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedRowIndex = dgvLichSuThuNhap.SelectedRows[0].Index;
                    int sttCT = Convert.ToInt32(dgvLichSuThuNhap.Rows[selectedRowIndex].Cells["STT_CT"].Value);

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
        private void ReloadData()
        {
            string query = "SELECT ChiTieu.STT_CT, ChiTieu.TenCT, ChiTieu.DMCT, ChiTieu.SoTien, ChiTieu.SoLuong, ChiTieu.NgayChi, ChiTieu.GhiChu FROM ChiTieu INNER JOIN TaiKhoan ON TaiKhoan.MaTK = ChiTieu.MaCT WHERE ChiTieu.MaCT = TaiKhoan.MaTK";
            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable = modify.GetData(query);
            dgvLichSuThuNhap.DataSource = dataTable;

            // Ẩn cột "STT_CT"
            dgvLichSuThuNhap.Columns["STT_CT"].Visible = false;
        }
    }
}
