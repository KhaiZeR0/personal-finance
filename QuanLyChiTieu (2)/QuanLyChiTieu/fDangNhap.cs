﻿using System;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace QuanLyChiTieu
{
    public partial class fDangNhap : Form
    {
        public static string namesend;
        public fDangNhap()
        {
            InitializeComponent();
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

            if (user_name == "" || pass_Word == "")
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");
            }
            else
            {
                string passHash = GenerateHash(pass_Word);
                string query = "select * from TaiKhoan where TenTK = '" + user_name + "' and MatKhau = '" + passHash + "'";
                namesend = (txtTenDangNhap.Text).ToString();
                if (modify.TaiKhoans(query).Count != 0)
                {
                    fQuanLyChiTieu quanLyChiTieu = new fQuanLyChiTieu();
                    quanLyChiTieu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
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
        private void fDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
