using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Tang
    {
        KhachSanEntities db = new KhachSanEntities();

        public List<tb_tang> getList()
        {
            return db.tb_tang.ToList();

        }
    }
}
