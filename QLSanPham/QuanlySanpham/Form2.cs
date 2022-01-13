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
    public partial class Form2 : Form
    {
        SanPhamBLL SPBLL = new SanPhamBLL();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            capNhatLuoi();
        }

        void capNhatLuoi()
        {
            dataGridView1.DataSource = SPBLL.danhsach();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            SPBLL.them(txtTenSP.Text, txtXuatXu.Text, decimal.Parse(txtGia.Text), dateTimePicker1.Value, txtMoTa.Text);
            MessageBox.Show("Thêm sản phẩm thành công !");
            capNhatLuoi();
           
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SPBLL.sua(int.Parse(txtMaSP.Text), txtTenSP.Text, txtXuatXu.Text, decimal.Parse(txtGia.Text), dateTimePicker1.Value, txtMoTa.Text);
            MessageBox.Show("Đã cập nhật sản phẩm !");
            capNhatLuoi();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow r = dataGridView1.SelectedRows[0];
                txtMaSP.Text = r.Cells["MaSP"].Value.ToString();
                txtTenSP.Text = r.Cells["TenSP"].Value.ToString();
                txtXuatXu.Text = r.Cells["XuatXu"].Value.ToString();
                txtGia.Text = r.Cells["Gia"].Value.ToString();
                dateTimePicker1.Value = (DateTime)r.Cells["NgayNhap"].Value;
                txtMoTa.Text = r.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SPBLL.xoa(int.Parse(txtMaSP.Text));
            MessageBox.Show("Đã xóa mặt hàng!");
            capNhatLuoi();
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMoTa_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
            this.Hide();
        }
    }
}
