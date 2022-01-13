using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class HoaDonBLL
    {
        QLBHDataContext DB = new QLBHDataContext();
        public HoaDonBLL()
        {

        }
        public List<HoaDon> LayTatCa()
        {
            return DB.HoaDons.ToList();
        }

        public void them(int mahoadon, string tennguoimua,string sdt, int masp, int soluong, int thanhtien)
        {
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = mahoadon;
            hd.SDT = sdt;
            hd.TenNguoiMua = tennguoimua;
            hd.MaSP = masp;
            hd.SoLuong = soluong;
            hd.ThanhTien = thanhtien;

            CultureInfo viVn = new CultureInfo("vi-VN");
            int day = DateTime.Now.Day;                    //Lấy ngày hiện tại
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            DateTime n = new DateTime(year, month, day, hour, minute, second);   
            string ngaytao = n.ToString("g", viVn);
            hd.ThoiGian = ngaytao;

            DB.HoaDons.InsertOnSubmit(hd);

            DB.SubmitChanges();
        }
        public int TongTien()
        {
            int tongtien = 0;
            List<HoaDon> hd = DB.HoaDons.Where(x => x.XacNhan == null).ToList();

            foreach (HoaDon t in hd)
            {
                tongtien += (int)t.ThanhTien;
            }
            return tongtien;
        }
        public void XacNhan()
        {
            List<HoaDon> hd = DB.HoaDons.Where(x => x.XacNhan == null).ToList();
            foreach (HoaDon h in hd)
            {
                h.XacNhan = 1;
            }

            DB.SubmitChanges();
        }
        public void Xoa()  //Xóa sp có xác nhận là null
        {
            List<HoaDon> cthd = DB.HoaDons.Where(x => x.XacNhan == null).ToList();
            foreach (HoaDon hd in cthd)
            {
                DB.HoaDons.DeleteOnSubmit(hd);
            }
            DB.SubmitChanges();
        }
        public HoaDon LayTheoMa(int ma)
        {
            return DB.HoaDons.FirstOrDefault(x => x.MaHoaDon == ma);
        }
        public string LayThoiGian(int m)
        {
            HoaDon ct = LayTheoMa(m);
            return ct.ThoiGian;
        }
        public string LayTen(int m)
        {
            HoaDon kh = LayTheoMa(m);
            return kh.TenNguoiMua;
        }

    }



}
