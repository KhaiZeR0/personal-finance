using System;
using System.Windows.Forms;

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
            dgvThongtin.Rows[selectedRow].Cells[0].Value = txtTen;
            dgvThongtin.Rows[selectedRow].Cells[1].Value = txtTien;
            dgvThongtin.Rows[selectedRow].Cells[2].Value = txtDM;
            dgvThongtin.Rows[selectedRow].Cells[3].Value = txtGC;
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
                if(txtTen.Text == "" || txtTien.Text == "" || txtDM.Text == "" || txtGC.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
                }
                int tenTrung=GetDaChon(txtTen.Text);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
