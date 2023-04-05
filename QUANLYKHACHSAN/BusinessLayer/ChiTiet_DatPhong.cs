using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    public class ChiTiet_DatPhong
    {
        KhachSanEntities db  = new KhachSanEntities();
        public List<tb_CT_DP> getAll()
        {
            return db.tb_CT_DP.ToList();

        }

        public tb_CT_DP getItem(int ma)
        {
            return db.tb_CT_DP.FirstOrDefault(X => X.MaCT_DP == ma);
        }
        public List<tb_CT_DP> getByDatPhong(int madat)
        {
            return db.tb_CT_DP.Where(x => x.MaDat == madat).ToList();
        }

        public tb_CT_DP add(tb_CT_DP _ct_dp)
        {
            try
            {
                db.tb_CT_DP.Add(_ct_dp);
                db.SaveChanges();
                return _ct_dp;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public tb_CT_DP update(tb_CT_DP _ctdp)
        {
            tb_CT_DP ctdp = db.tb_CT_DP.FirstOrDefault(x => x.MaCT_DP == _ctdp.MaCT_DP);
            ctdp.MaPhong = _ctdp.MaPhong;
            ctdp.MaDat = _ctdp.MaDat;
            ctdp.MaCT_DP = _ctdp.MaCT_DP;
            ctdp.DonGia = _ctdp.DonGia;
            ctdp.SoNgayO = _ctdp.SoNgayO;
            ctdp.ThanhTien = _ctdp.ThanhTien;
            try
            {
                db.SaveChanges();
                return ctdp;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }
     
        public void delete(int _maDP , int _maphong)   
        {
            tb_CT_DP ctdp = db.tb_CT_DP.FirstOrDefault(x => x.MaDat == _maDP && x.MaPhong==_maphong);
            try
            {
                db.tb_CT_DP.Remove(ctdp);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }

        }

        public void deleteAll(int maDP)
        {
            List<tb_CT_DP> lstCTDP = db.tb_CT_DP.Where(x => x.MaDat == maDP).ToList();
            try
            {
                db.tb_CT_DP.RemoveRange(lstCTDP);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }
    }
}
