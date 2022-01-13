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
    public partial class frmXuatBill : Form
    {
        SanPhamBLL SPBLL = new SanPhamBLL();
        HoaDonBLL HDBLL = new HoaDonBLL();
        public frmXuatBill(int mahoadon, int tongthanhtoan)
        {
            this.MaHoaDon = mahoadon;
            this.TongThanhToan = tongthanhtoan;
            InitializeComponent();
        }
        private int MaHoaDon;
        private int TongThanhToan;

        private void frmXuatBill_Load(object sender, EventArgs e)
        {
            var ds = from h in SPBLL.danhsach()
                     join d in HDBLL.LayTatCa() on h.MaSP equals d.MaSP
                     where d.MaHoaDon == MaHoaDon
                     select new
                     {
                         h.TenSP,
                         d.SoLuong,
                         d.ThanhTien,
                         d.TenNguoiMua,
                         d.SDT
                     };
            dgvXuatBill.DataSource = ds.ToList();
            dgvXuatBill.Columns["ThanhTien"].DefaultCellStyle.Format = "N0";

            lblTongThanhTien.Text = "Tổng tiền cần thanh toán: " + String.Format("{0:0,0 USD}", TongThanhToan);

           
            lblThoiGian.Text = HDBLL.LayThoiGian(MaHoaDon).ToString();
            lblTenKH.Text = HDBLL.LayTen(MaHoaDon).ToString();
        }

        private void lblThoiGian_Click(object sender, EventArgs e)
        {

        }

        private void lblTongThanhTien_Click(object sender, EventArgs e)
        {

        }

        private void lblBill_Click(object sender, EventArgs e)
        {

        }
    }
}
