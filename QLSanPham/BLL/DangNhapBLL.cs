using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using DAL;

namespace BLL
{
    
   public class DangNhapBLL
    {
        public DangNhapBLL()
        {

        }
        QLBHDataContext DB = new QLBHDataContext();
            public List<NhanVien> danhsach()
        {
            return DB.NhanViens.ToList();
        }

        public void them(string TaiKhoan, string MatKhau, string TenNV)
        {
            NhanVien nv = new NhanVien();
            nv.TenDangNhap = TaiKhoan;
            nv.MatKhau = MatKhau;
            nv.TenNV = TenNV;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }
    }

}
