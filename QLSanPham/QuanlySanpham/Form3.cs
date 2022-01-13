using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace QuanlySanpham
{
    public partial class Form3 : Form
    {
        DangNhapBLL DNBLL = new DangNhapBLL();
        public Form3()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Bạn thiếu tên đăng ký");
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn thiếu mật khẩu");
                return;
            }
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Bạn thiếu tên nhân viên");
                return;
            }
            if (txtMatKhau.Text == txtXNMatKhau.Text)
            {
                string matkhauMD5 = CreateMD5(txtMatKhau.Text);

                DNBLL.them(txtTaiKhoan.Text, matkhauMD5, txtTenNV.Text);
                MessageBox.Show("Đăng ký tài khoản thành công!");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng");
                return;
            }
            
            

        }
        private string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dn = new Form1();
            dn.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
