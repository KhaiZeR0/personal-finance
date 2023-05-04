using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace QuanLyChiTieu
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }
            //kiểm tra tài khoản và mật khẩu
        public bool checkAccount(string acc)
        {
            return Regex.IsMatch(acc, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w]{3,20}@gmail.com(.vn|)$");
        }

        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            string xnmk = txtXacNhanMatKhau.Text;
            string email = txtEmail.Text;

            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (!checkAccount(xnmk)) { MessageBox.Show("Xác nhận mật khẩu không trùng khớp!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dang email"); return; }
            if (modify.TaiKhoans("select * from TaiKhoan where Email_TK = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký!"); } 
            
            try
            {
                string query = "insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                MessageBox.Show("Bạn đãn đăng ký thành công", "Thông báo!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng nhập tài khoản khác");
            }      
        }
    }
}
