using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NhanVien
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_nhanvien> getAll()
        {
            return db.tb_nhanvien.ToList();

        }

        public tb_nhanvien getItem(int manhanvien)
        {
            return db.tb_nhanvien.FirstOrDefault(X => X.MaNV == manhanvien);
        }

        public void add(tb_nhanvien nv)
        {
            try
            {
                db.tb_nhanvien.Add(nv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_nhanvien nhanvien)
        {
            tb_nhanvien nv = db.tb_nhanvien.FirstOrDefault(x => x.MaNV == nhanvien.MaNV);
            nv.TenNV = nhanvien.TenNV;
            nv.DiaChi = nhanvien.DiaChi;
            nv.Email = nhanvien.Email;
            nv.DienThoai = nhanvien.DienThoai;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }

        public void delete(int manhanvien)
        {
            try
            {
                var nhanvien = db.tb_nhanvien.FirstOrDefault(x => x.MaNV == manhanvien);
                db.tb_nhanvien.Remove(nhanvien);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}
