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
using System.Security.Cryptography;

namespace QuanLyChiTieu
{
    public partial class fResetPass : Form
    {
        string emaildt = fQuenMatKhau.to;
        public fResetPass()
        {
            InitializeComponent();
        }

        private void newpassword_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox2.Text;
            if (textBox1.Text == textBox2.Text)
            {
                string matkhau = textBox1.Text;
                string email = emaildt;
                string passHash = GenerateHash(matkhau);

                string query = "update [regtable] set [Password]='" + passHash + "' where Email='" + email + "'";
                modify.Command(query);
                MessageBox.Show("Bạn đã đổi mật khẩu thành thông, vui lòng chuyển sang trang đăng nhập.", "Thông báo!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật Khẩu bạn nhập không khớp, vui lòng nhập lại.");
            }
        }
        private static string GenerateHash(string toHash)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(toHash));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }
    }
}
