using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NhaCungCap
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_nhacungcap> getAll()
        {
            return db.tb_nhacungcap.ToList();

        }

        public tb_nhacungcap getItem(int maNcc)
        {
            return db.tb_nhacungcap.FirstOrDefault(X => X.MaNCC == maNcc);
        }

        public void add(tb_nhacungcap ncc)
        {
            try
            {
                db.tb_nhacungcap.Add(ncc);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_nhacungcap nhacungcap)
        {
            tb_nhacungcap ncc = db.tb_nhacungcap.FirstOrDefault(x => x.MaNCC == nhacungcap.MaNCC);
            ncc.TenNCC = nhacungcap.TenNCC;
            ncc.DiaChi = nhacungcap.DiaChi;
            ncc.DienThoai = nhacungcap.DienThoai;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int mancc)
        {
            try
            {
                var nhacungcap = db.tb_nhacungcap.FirstOrDefault(x => x.MaNCC == mancc);
                db.tb_nhacungcap.Remove(nhacungcap);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}

