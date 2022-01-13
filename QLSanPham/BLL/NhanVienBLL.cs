using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        QLBHDataContext DB = new QLBHDataContext();
        public NhanVienBLL()
        {

        }

        public List<NhanVien> danhsach()
        {
            return DB.NhanViens.ToList();
        }

        public void them(string tendangnhap, string matkhau, string tennhanvien)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = tendangnhap;
            nv.MatKhau = matkhau;
            nv.TenNV = tennhanvien;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }

        public NhanVien LayTheoTenDangNhapVaMatKhau(string tendangnhap, string matkhau)
        {
            return DB.NhanViens.Where(nv => nv.TenDangNhap == tendangnhap && nv.MatKhau == matkhau).FirstOrDefault();
        }
    }
}
