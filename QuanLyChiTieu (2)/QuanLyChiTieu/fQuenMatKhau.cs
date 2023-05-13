using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChiTieu
{
    public partial class fQuenMatKhau : Form
    {
        string randomcode;
        public static string to;
        public fQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnlayma_Click(object sender, EventArgs e)
        {

            // send code
            string from, pass, messagebody;
            Random rand = new Random();
            randomcode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (textBox1.Text).ToString();
            from = "khai.sendmail@gmail.com";
            pass = "xsjayaiphjedablr";
            messagebody = $"Mã của bạn là: {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Mã lấy lại mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Gửi mã thành công, vui lòng check hòm thư của bạn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (randomcode == (textBox2.Text).ToString())
            {
                to = textBox1.Text;
                fResetPass fResetPass = new fResetPass();
                fResetPass.Show();
            }
            else
            {
                MessageBox.Show("Sai mã, vui lòng nhập lại.");
            }
        }

        private void fQuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}