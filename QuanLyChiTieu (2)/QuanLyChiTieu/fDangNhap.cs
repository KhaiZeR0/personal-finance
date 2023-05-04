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
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        
        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void link_lblQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fQuenMatKhau quenMatKhau = new fQuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void link_lblDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fDangKy dangKy = new fDangKy();
            dangKy.ShowDialog();
        }

        Modify modify = new Modify();

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user_name = txtTenDangNhap.Text;
            string pass_Word = txtMatKhau.Text;

            if(user_name == "" || pass_Word == "")
            {
                MessageBox.Show("Vui lòng không để trống!","Thông báo");
            }    
            else
            {
                string query = "select * from TaiKhoan where TenTK = '"+user_name+"' and MatKhau = '"+pass_Word+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    fQuanLyChiTieu quanLyChiTieu = new fQuanLyChiTieu();
                    quanLyChiTieu.ShowDialog();
                }    
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }    
            }
        }

        bool Login(string userName, string passWord)
        {
            return false;
        }
    }
}
