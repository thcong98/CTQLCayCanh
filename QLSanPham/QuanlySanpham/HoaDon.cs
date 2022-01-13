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
    public partial class HoaDon : Form
    {
        SanPhamBLL SPBLL = new SanPhamBLL();
        HoaDonBLL HDBLL = new HoaDonBLL();
        int MaHoaDon;
        int TongThanhToan;
        public HoaDon()
        {
            InitializeComponent();
        }



        public void LoadHD()
        {

            this.cbbHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbHoaDon.DataSource = SPBLL.danhsach(); 
            cbbHoaDon.DisplayMember = "TenSP";    //Hiện tên
            cbbHoaDon.ValueMember = "MaSP";       //Lấy giá trị là ID
            cbbHoaDon.SelectedIndex = -1;     //Không chọn giá trị mặc định của CBB
            
            TongThanhToan = HDBLL.TongTien();
            lblTongTien.Text = "Số tiền cần thanh toán: " + String.Format("{0:0,0 USD}", TongThanhToan);

            var ds = from h in SPBLL.danhsach()
                     join d in HDBLL.LayTatCa() on h.MaSP equals d.MaSP
                     where d.XacNhan == null
                     select new
                     {
                         d.Id,
                         h.TenSP,
                         d.SoLuong,
                         d.ThanhTien
                     };
            dgvHoaDon.DataSource = ds.ToList();

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadHD();
            dgvHoaDon.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";
            dgvHoaDon.Columns[0].Visible = false;
            Random rand = new Random();
            MaHoaDon = rand.Next(1000, 9999);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            HDBLL.XacNhan();
            new frmXuatBill(MaHoaDon, TongThanhToan).ShowDialog();
            LoadHD();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbHoaDon.Text))
            {
                MessageBox.Show("Vui lòng chọn tên cây");
                return;
            }
            if(string.IsNullOrEmpty(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập só lượng");
                return;
            }
            if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            if (string.IsNullOrEmpty(txtKhachHang.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                return;
            }
            int MaSP = int.Parse(cbbHoaDon.SelectedValue.ToString());
            int SoLuong = int.Parse(txtSoLuong.Text);

            SanPham sp = SPBLL.layTheoMa(MaSP);
            int ThanhTien = (int)sp.Gia * SoLuong;
            string TenKhacHang = txtKhachHang.Text;
            string SoDienThoai = txtSDT.Text;
            HDBLL.them(MaHoaDon, TenKhacHang, SoDienThoai, MaSP, SoLuong, ThanhTien);
            MessageBox.Show("Thêm vào hóa đơn thàng công!");
            LoadHD();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            HDBLL.Xoa();
            LoadHD();
        }

        private void HoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            HDBLL.Xoa();
            
        }
    }
}
