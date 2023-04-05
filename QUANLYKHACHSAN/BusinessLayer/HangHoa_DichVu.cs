using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class HangHoa_DichVu
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_hanghoa_dichvu> getList()
        {
            return db.tb_hanghoa_dichvu.ToList();
        }
        public tb_hanghoa_dichvu getItem(int mahh_dv)
        {
            return db.tb_hanghoa_dichvu.FirstOrDefault(X => X.MaHH_DV == mahh_dv);
        }



        public void add(tb_hanghoa_dichvu hh_dv)
        {
            try
            {
                db.tb_hanghoa_dichvu.Add(hh_dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_hanghoa_dichvu hanghoa_dichvu)
        {
            tb_hanghoa_dichvu hh_dv = db.tb_hanghoa_dichvu.FirstOrDefault(x => x.MaHH_DV == hanghoa_dichvu.MaHH_DV);
            hh_dv.TenHH_DV = hanghoa_dichvu.TenHH_DV;
            hh_dv.DonGia = hanghoa_dichvu.DonGia;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int mahh_dv)
        {
            try
            {
                var hh_dv = db.tb_hanghoa_dichvu.FirstOrDefault(x => x.MaHH_DV == mahh_dv);
                db.tb_hanghoa_dichvu.Remove(hh_dv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }
    }
}
