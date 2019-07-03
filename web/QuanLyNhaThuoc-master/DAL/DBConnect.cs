using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection con = new SqlConnection(@"Data Source = (local); Initial Catalog = Quan ly nha thuoc c#; Integrated Security = True");
        public void openC()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public void closeC()
        {
            try
            {
                con.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

