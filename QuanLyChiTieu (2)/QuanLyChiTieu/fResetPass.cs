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
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;

namespace QuanLyChiTieu
{
    public partial class fResetPass : Form
    {
        string emailGO = fQuenMatKhau.to;
        public fResetPass()
        {
            InitializeComponent();
        }

        private void newpassword_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();

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

        private void button1_Click_1(object sender, EventArgs e)
        {

            string matkhau = textBox2.Text;
            string xnmk = textBox1.Text;
            string email = emailGO;

            if (xnmk != matkhau) { MessageBox.Show("Xác nhận mật khẩu không trùng khớp!"); return; }

            else
            {
                try
                {
                    string passHash = GenerateHash(matkhau);
                    string sql = "UPDATE Taikhoan SET MatKhau = '" + passHash + "' WHERE Email_TK ='" + email +"'";
                    modify.Command(sql);
                    MessageBox.Show("mật khẩu đã được cập nhật.", "Thông báo!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại, vui lòng thử lại sau.");
                }
            }
        }
    }
}
