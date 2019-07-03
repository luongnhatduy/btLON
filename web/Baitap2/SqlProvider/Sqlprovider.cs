using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SqlProvider
{
    public class Sqlprovider
    {
        private string connStr = @"Data Source=USER-PC;"
            + "Initial Catalog = Baitap5;"
            + "Integrated Security = SSPI;";
        // +"Uid = " + "Password ="
        public SqlConnection conn = null;

        public Sqlprovider()
        {
            conn = new SqlConnection(connStr);
        }
        public SqlConnection getConnect()
        {
            if (conn == null || conn.State == ConnectionState.Closed)
            {
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            return conn;
        }
    }
}
