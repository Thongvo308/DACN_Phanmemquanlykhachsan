
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRANGTHAI
    {
        public bool value { set; get; }
        public string display { set; get; }
        public TRANGTHAI()
        {

        }
        public TRANGTHAI(bool value, string display)
        {
            this.value = value;
            this.display = display;
        }

        public static List<TRANGTHAI> getList()
        {
            List<TRANGTHAI> lst = new List<TRANGTHAI>();
            TRANGTHAI[] collect = new TRANGTHAI[2]
            {
                new TRANGTHAI(false, "Chưa hoàn tất"),
                new TRANGTHAI(true, "Hoàn tất")

            };
            lst.AddRange(collect);
            return lst;
        }
    }
}
