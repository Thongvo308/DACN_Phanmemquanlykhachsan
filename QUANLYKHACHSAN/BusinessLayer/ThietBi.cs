using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThietBi
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_thietbi> getAll()
        {
            return db.tb_thietbi.ToList();

        }

        public tb_thietbi getItem(int maTB)
        {
            return db.tb_thietbi.FirstOrDefault(X => X.MaTB == maTB);
        }

        public void add(tb_thietbi tb)
        {
            try
            {
                db.tb_thietbi.Add(tb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_thietbi thietbi)
        {
            tb_thietbi tb = db.tb_thietbi.FirstOrDefault(x => x.MaTB == thietbi.MaTB);
            tb.TenTB = thietbi.TenTB;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int mathietbi)
        {
            try
            {
                var thietbi = db.tb_thietbi.FirstOrDefault(x => x.MaTB == mathietbi);
                db.tb_thietbi.Remove(thietbi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}
