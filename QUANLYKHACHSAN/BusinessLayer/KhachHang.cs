using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhachHang
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_khachhang> getAll()
        {
            return db.tb_khachhang.ToList();

        }


        public List<tb_khachhang> getList()
        {
            return db.tb_khachhang.ToList();
        }
        public tb_khachhang getItem(int makhachhang)
        {
            return db.tb_khachhang.FirstOrDefault(X => X.MaKH == makhachhang);
        }

        public void add(tb_khachhang kh)
        {
            try
            {
                db.tb_khachhang.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_khachhang khachhang)
        {
            tb_khachhang kh = db.tb_khachhang.FirstOrDefault(x => x.MaKH == khachhang.MaKH);
            kh.TenKH = khachhang.TenKH;
            kh.DiaChi = khachhang.DiaChi;
            kh.DienThoai = khachhang.DienThoai;
            kh.CCCD = khachhang.CCCD;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int makhachhang)
        {
            try
            {
                var khachhang = db.tb_khachhang.FirstOrDefault(x => x.MaKH == makhachhang);
                db.tb_khachhang.Remove(khachhang);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}
