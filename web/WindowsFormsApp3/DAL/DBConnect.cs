using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con;
        public void openC()
        {
            string strConnect = @"Data Source=DESKTOP-M1SQM9D\SQLEXPRESS;Initial Catalog=dienmay;Integrated Security=True";
            con = new SqlConnection(strConnect);
            con.Open();
        }
        public void closeC()
        {
            con.Close();
        }
    }
}
