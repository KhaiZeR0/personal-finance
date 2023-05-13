using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyChiTieu
{
    public partial class fThemChiTieu : Form
    {
        public fThemChiTieu()
        {
            InitializeComponent();
        }
        private void capNhat(int selectedRow)
        {
            dgvThongtin.Rows[selectedRow].Cells[0].Value = txtTen.Text;
            dgvThongtin.Rows[selectedRow].Cells[1].Value = txtTien.Text;
            dgvThongtin.Rows[selectedRow].Cells[2].Value = txtDM.Text;
            dgvThongtin.Rows[selectedRow].Cells[3].Value = txtSL.Text;
            dgvThongtin.Rows[selectedRow].Cells[4].Value = txtGC.Text;
        }
        
        private void dgvThongtin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private int GetDaChon(string colTen)
        {
            for (int i = 0; i < dgvThongtin.Rows.Count; i++)
            {
                if (dgvThongtin.Rows[i].Cells[0].Value.ToString().Contains(colTen))
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txtTien.Text == "" )
                {
                    MessageBox.Show("Vui lòng không để trống số tiền","Thông báo");
                }
                /*int tenTrung = GetDaChon(txtTen.Text);*/
                else if (txtDM.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống danh mục chi tiêu", "Thông báo");

                }
                else if (txtSL.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống số lượng", "Thông báo");

                }
                else
                {
                    int temp = GetDaChon(txtTen.Text);
                    temp = dgvThongtin.Rows.Add();

                    capNhat(temp);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public delegate void SendMessage(String value);
        public delegate void PassDataDelegate(string cellValue);
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
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
    }
}
