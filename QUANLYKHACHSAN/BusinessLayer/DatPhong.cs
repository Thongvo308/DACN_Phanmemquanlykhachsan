using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DatPhong
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_datphong> getAll()
        {
            return db.tb_datphong.ToList();

        }

        public List<tb_datphong> getList()
        {
            return db.tb_datphong.ToList();
        }

        public List<OBJ_DatPhong> getAll(DateTime tungay, DateTime denngay)
        {
           var listDP = db.tb_datphong.Where(x =>x.NgayDat>=tungay && x.NgayTra<denngay).ToList();
            List<OBJ_DatPhong>lstDP=new List<OBJ_DatPhong>();
            OBJ_DatPhong dp;
            foreach(var item in listDP)
            {
                dp = new OBJ_DatPhong();
                dp.MaDat = item.MaDat;
                dp.MaKH = item.MaKH;
                dp.MaPhong = item.MaPhong;
                var kh = db.tb_khachhang.FirstOrDefault(x => x.MaKH == item.MaKH);
                dp.TenKH = kh.TenKH;
                dp.NgayDat = item.NgayDat;
                dp.NgayTra = item.NgayTra;
                dp.SoNguoiO = item.SoNguoiO;
                dp.SoTien = item.SoTien;
                dp.TrangThai = item.TrangThai;
                lstDP.Add(dp);
            }
            return lstDP;
                
        }

        public tb_datphong getItem(int ma)
        {
            return db.tb_datphong.FirstOrDefault(X => X.MaDat == ma);
        }

        public tb_datphong add(tb_datphong _dp)
        {
            try
            {
                db.tb_datphong.Add(_dp);
                db.SaveChanges();
                return _dp;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình xử lý." + ex.Message);
            }
        }

        public tb_datphong update(tb_datphong _dp)
        {
            tb_datphong dp = db.tb_datphong.FirstOrDefault(x => x.MaDat == _dp.MaDat);
            dp.MaKH = _dp.MaKH;
            dp.MaPhong = _dp.MaPhong;
            dp.NgayDat = _dp.NgayDat;
            dp.NgayTra = _dp.NgayTra;
            dp.SoTien = _dp.SoTien;
            dp.SoNguoiO = _dp.SoNguoiO;
            dp.CREATED_DATE = _dp.CREATED_DATE;

            try
            {
                db.SaveChanges();
                return dp;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
        public void delete(int ma)
        {
            try
            {
                var datphong = db.tb_datphong.FirstOrDefault(x => x.MaDat == ma);
                db.tb_datphong.Remove(datphong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
    }
}
