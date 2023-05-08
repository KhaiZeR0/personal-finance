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
                if (txtTen.Text == "" || txtTien.Text == "")
                {
                    MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
                }
                int tenTrung = GetDaChon(txtTen.Text);
                if (tenTrung == -1)
                {
                    tenTrung = dgvThongtin.Rows.Add();
                    capNhat(tenTrung);
                }
                else
                {
                    capNhat(tenTrung);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


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
    }
}
