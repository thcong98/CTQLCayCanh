using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        QLBHDataContext DB = new QLBHDataContext();
        public SanPhamBLL()
        {

        }

        public List<SanPham> danhsach()
        {
            return DB.SanPhams.ToList();
        }
        

        public void them(string tensp, string xuatxu, decimal gia,DateTime ngaynhap, string mota)
        {
            SanPham sp = new SanPham();
            sp.TenSP = tensp;
            sp.XuatXu = xuatxu;
            sp.Gia = gia;
            sp.NgayNhap = ngaynhap;
            sp.MoTa = mota;

            DB.SanPhams.InsertOnSubmit(sp);

            DB.SubmitChanges();
        }

        public SanPham layTheoMa(int maSP)
        {
            return DB.SanPhams.Where(sp => sp.MaSP == maSP).FirstOrDefault();

        }

        public void sua(int ma, string tensp, string xuatxu, decimal gia, DateTime ngaynhap, string mota)
        {
            SanPham sp = layTheoMa(ma);
            sp.TenSP = tensp;
            sp.XuatXu = xuatxu;
            sp.Gia = gia;
            sp.NgayNhap = ngaynhap;
            sp.MoTa = mota;

            DB.SubmitChanges();
        }

        public void xoa(int ma)
        {
            SanPham sp = layTheoMa(ma);
            DB.SanPhams.DeleteOnSubmit(sp);

            DB.SubmitChanges();
        }
    }
}
