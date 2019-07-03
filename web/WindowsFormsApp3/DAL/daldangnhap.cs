using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class daldangnhap
    {
        public string Checklogin(string ID, String PASS)
        {
            SqlConnection conn;
            string strConnect = @"Data Source=DESKTOP-M1SQM9D\SQLEXPRESS;Initial Catalog=dienmay;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();

            SqlCommand cmd = new SqlCommand("usp_DANGNHAP", conn);


            cmd.Parameters.Add("@ID", SqlDbType.Char).Value = ID;
            cmd.Parameters.Add("@PASS", SqlDbType.Char).Value = PASS;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            string ketqua = (string)cmd.ExecuteScalar();
            return ketqua;
        }
    }
}
