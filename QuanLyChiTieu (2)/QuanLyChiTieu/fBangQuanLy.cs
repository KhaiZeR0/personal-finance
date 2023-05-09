using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fQuanLyChiTieu : Form
    {

        public fQuanLyChiTieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel7_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            fThemChiTieu themchitieu = new fThemChiTieu();
            themchitieu.ShowDialog();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            fHistory fHistory = new fHistory();
            fHistory.ShowDialog();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            fthunhap fthunhap = new fthunhap();
            fthunhap.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            Groupinfo groupinfo = new Groupinfo();
            groupinfo.ShowDialog();
        }
    }
}
