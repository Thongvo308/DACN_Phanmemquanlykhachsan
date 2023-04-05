using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DatPhong_HH_DV
    {
        KhachSanEntities db = new KhachSanEntities();


        public List<OBJ_DP_DV> getAllByDatPhong(int maDP)
        {
            var list = db.tb_DP_HH_DV.Where(x => x.MaDat==maDP).ToList();
            List<OBJ_DP_DV> listDV = new List<OBJ_DP_DV>();
            OBJ_DP_DV dv;
            foreach (var item in list)
            {
                dv = new OBJ_DP_DV();
                dv.MaDP_HH_DV = item.MaDP_HH_DV;
                dv.MaDat = item.MaDat;
                dv.MaPhong = item.MaPhong;
                var ph = db.tb_phong.FirstOrDefault(x => x.MaPhong == item.MaPhong);
                dv.TenPhong = ph.TenPhong;
             //   dv.MaHH_DV = item.MaHH_DV;
                var hhdv = db.tb_hanghoa_dichvu.FirstOrDefault(x => x.MaHH_DV == item.MaHH_DV);
                dv.TenHH_DV = hhdv.TenHH_DV;
                dv.SoLuong = item.SoLuong;
                dv.DonGia = item.DonGia;
                dv.ThanhTien = item.ThanhTien;
                listDV.Add(dv);
            }
            return listDV;
        }
        public void add(tb_DP_HH_DV dp_hhdv)
        {
            try
            {
                db.tb_DP_HH_DV.Add(dp_hhdv);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }

        public void deleteAll(int maDP)
        {
            List<tb_DP_HH_DV> lstDV = db.tb_DP_HH_DV.Where(x => x.MaDat == maDP).ToList();
            try
            {
                db.tb_DP_HH_DV.RemoveRange(lstDV);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }
        public void deleteAllByPhong(int maDP, int _maphong)
        {
            List<tb_DP_HH_DV> lstDV = db.tb_DP_HH_DV.Where(x => x.MaDat == maDP && x.MaPhong==_maphong).ToList();
            try
            {
                db.tb_DP_HH_DV.RemoveRange(lstDV);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xãy ra trong quá trình sử lý." + ex.Message);
            }
        }
    }
}
