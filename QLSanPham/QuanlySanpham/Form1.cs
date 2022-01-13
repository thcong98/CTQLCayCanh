using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace QuanlySanpham
{

    public partial class Form1 : Form
    {
        NhanVienBLL NVBLL = new NhanVienBLL();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTendangnhap.Text))
            {
                MessageBox.Show("Bạn thiếu tên đăng nhập");
                return;
            }
            if (string.IsNullOrEmpty(txtMatkhau.Text))
            {
                MessageBox.Show("Bạn thiếu mật khẩu");
                return;
            }
            string matkhauMD5 = CreateMD5(txtMatkhau.Text);
            //Console.WriteLine("mak" + matkhauMD5);
            NhanVien nhanVien = NVBLL.LayTheoTenDangNhapVaMatKhau(txtTendangnhap.Text, matkhauMD5);
            if(nhanVien!=null)
            {
                //qua Form 2
                Form2 f2 = new Form2();
                Hide();
                f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);
                f2.ShowDialog();
            }
            else
            {
                //báo lỗi
                MessageBox.Show("Ten dang nhap hoac mat khau ko dung");
            }
        }
        private void f2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            

        }
    }
}
