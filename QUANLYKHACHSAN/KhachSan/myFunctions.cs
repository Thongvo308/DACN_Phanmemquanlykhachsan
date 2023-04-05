using DevExpress.Utils.Filtering.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan
{
    public class myFunctions
    {
        static SqlConnection con = new SqlConnection();
 
        public static void taoketnoi()
        {
            con.ConnectionString = "Data Source =DESKTOP-A9L9K71\\SQLEXPRESS; Initial Catalog =quanlykhachsan; User ID=sa;Password=sa123;";
            try
            {
                con.Open();
            }
            catch(Exception)
            {
                con.Close();
            }
        }

        public static void dongketnoi()
        {
            con.Close();
        }


        
        public static DataTable laydulieu(string qr)
        {
            taoketnoi();
            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(qr, con);
            adapter.Fill(data);
            dongketnoi();   
            return data;
        }
      
        public static DateTime GetFirstDayInMont(int year, int month)
        {
            return new DateTime(year, month, 1);

        }
    }
}
