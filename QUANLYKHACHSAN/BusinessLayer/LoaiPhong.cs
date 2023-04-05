using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    
    public class LoaiPhong
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_loaiphong> getAll()
        {
            return db.tb_loaiphong.ToList();   
        
        }

        public tb_loaiphong getItem(int maLoai)
        {
            return db.tb_loaiphong.FirstOrDefault(X => X.MaLoai == maLoai);
        }

        public void add(tb_loaiphong lp)
        {
            try
            {
                db.tb_loaiphong.Add(lp);
                db.SaveChanges();
            }   
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý."+ex.Message);
            }
        }

        public void update(tb_loaiphong loaiphong)
        {
            tb_loaiphong lp = db.tb_loaiphong.FirstOrDefault(x => x.MaLoai == loaiphong.MaLoai);
            lp.TenLoai = loaiphong.TenLoai;
            lp.DonGia = loaiphong.DonGia;
            lp.SoGiuong = loaiphong.SoGiuong;
            lp.SoNguoi = loaiphong.SoNguoi;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int maloai)
        {
            try
            {
                var loaiphong = db.tb_loaiphong.FirstOrDefault(x => x.MaLoai == maloai);
                db.tb_loaiphong.Remove(loaiphong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}
