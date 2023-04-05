using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Phong
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_phong> getAll()
        {
            return db.tb_phong.ToList();
        }

        public List<tb_phong> getList()
        {
            return db.tb_phong.ToList();
        }


        public tb_phong getItem(int ma)
        {
            return db.tb_phong.FirstOrDefault(x => x.MaPhong == ma);
        }

        public List<tb_phong> getByTang(int sotang)
        {
            return db.tb_phong.Where(x => x.SoTang == sotang).ToList();
        }

        public tb_phong add(tb_phong _phong)
        {
            try
            {
                db.tb_phong.Add(_phong);
                db.SaveChanges();
                return _phong;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void update(tb_phong phong)
        {
            tb_phong p = db.tb_phong.FirstOrDefault(x => x.MaPhong == phong.MaPhong);
            p.MaLoai = phong.MaLoai;
            p.SoTang = phong.SoTang;
            p.TenPhong = phong.TenPhong;
            p.TrangThai = phong.TrangThai;
            db.SaveChanges();
        }

        public void updateStatus(int? ma, bool trangthai)
        {
            tb_phong p = db.tb_phong.FirstOrDefault(x => x.MaPhong == ma);
            p.TrangThai = trangthai;
            db.SaveChanges();
        }


        public void delete(int maphong)
        {
            tb_phong phong = db.tb_phong.FirstOrDefault(x => x.MaPhong == maphong);
            db.SaveChanges();
        }

        public OBJ_Phong getItemFull(int ma)
        {
            var _p = db.tb_phong.FirstOrDefault(x => x.MaPhong == ma);
            OBJ_Phong phong = new OBJ_Phong();
            phong.MaPhong = _p.MaPhong;
            phong.TenPhong = _p.TenPhong;
            phong.TrangThai = bool.Parse(_p.TrangThai.ToString());
          //  phong.SoTang = _p.SoTang;
            var _tang = db.tb_tang.FirstOrDefault(x => x.SoTang == _p.SoTang);
            phong.TenTang = _tang.TenTang;
            var _loaiphong = db.tb_loaiphong.FirstOrDefault(x => x.MaLoai == _p.MaLoai);
            phong.TenLoai = _loaiphong.TenLoai;
            phong.DonGia = double.Parse(_loaiphong.DonGia.ToString());
            return phong;
        }

        public List<OBJ_Phong> getListFull()
        {
            var lsphong = db.tb_phong.ToList();
            List<OBJ_Phong> lsphongobj = new List<OBJ_Phong>();
            OBJ_Phong phong;
            foreach (var _p in lsphong)
            {
                phong = new OBJ_Phong();
                phong.MaPhong = _p.MaPhong;
                phong.TenPhong = _p.TenPhong;
                phong.TrangThai = bool.Parse(_p.TrangThai.ToString());
               // phong.SoTang = _p.SoTang;
                var _tang = db.tb_tang.FirstOrDefault(x => x.SoTang == _p.SoTang);
                phong.TenTang = _tang.TenTang;
                var _loaiphong = db.tb_loaiphong.FirstOrDefault(x => x.MaLoai == _p.MaLoai);
                phong.TenLoai = _loaiphong.TenLoai;
                phong.DonGia = double.Parse(_loaiphong.DonGia.ToString());
                lsphongobj.Add(phong);
            }
            return lsphongobj;
        }

        public List<OBJ_Phong> getphongtrongfull()
        {
            var lsphong = db.tb_phong.Where(x => x.TrangThai == false).ToList();
            List<OBJ_Phong> lsphongobj = new List<OBJ_Phong>();
            OBJ_Phong phong;
            foreach (var _p in lsphong)
            {
                phong = new OBJ_Phong();
                phong.MaPhong = _p.MaPhong;
                phong.TenPhong = _p.TenPhong;
                phong.TrangThai = bool.Parse(_p.TrangThai.ToString());
                //phong.SoTang = _p.SoTang;
                var _tang = db.tb_tang.FirstOrDefault(x => x.SoTang == _p.SoTang);
                phong.TenTang = _tang.TenTang;
                var _loaiphong = db.tb_loaiphong.FirstOrDefault(x => x.MaLoai == _p.MaLoai);
                phong.TenLoai = _loaiphong.TenLoai;
                phong.DonGia = double.Parse(_loaiphong.DonGia.ToString());
                lsphongobj.Add(phong);
            }
            return lsphongobj;
        }

        public bool check(int maphong)
        {
            var p = db.tb_phong.FirstOrDefault(x => x.MaPhong == maphong);
            if (p.TrangThai == true)
                return true;
            else
                return false;
        }
    }
}
