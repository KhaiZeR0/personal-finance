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
    public partial class fthunhap : Form
    {
        List<Thunhapcanhan> thuNhapList = new List<Thunhapcanhan>();
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
                if ( txtThuNhap.Text == "")
                {
                    MessageBox.Show("Vui lòng không bỏ trống số tiền!", "Thông Báo!");
                    return;
                }

                try
                {
                    int.Parse(txtThuNhap.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập Số Tiền là số!", "Thông Báo!");
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
    }
}
