using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class FUNC
    {

        KhachSanEntities db = new KhachSanEntities();


        public List<tb_func> getParent()
        {
            return db.tb_func.Where(x => x.Isgroup == true && x.Menu == true).OrderBy(s => s.Sort).ToList();
        }
        public List<tb_func> getChild(string parent)
        {
            return db.tb_func.Where(x => x.Isgroup == false && x.Menu == true && x.Parent == parent).OrderBy(s => s.Sort).ToList();
        }
    }
}
