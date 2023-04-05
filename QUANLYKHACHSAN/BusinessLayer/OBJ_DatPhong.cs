using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_DatPhong
    {

        public int MaDat { get; set; }
        public int? MaKH { get; set; }
        public int? MaPhong { get; set; }
        public string TenKH { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayTra { get; set; }
        public double? SoTien { get; set; }
        public int? SoNguoiO { get; set; }
        public int? MaNV { get; set; }
        public bool? TrangThai { get; set; }
        public bool? DISABLED { get; set; }
        public int? SoNgayO { get; set; }



    }
}
