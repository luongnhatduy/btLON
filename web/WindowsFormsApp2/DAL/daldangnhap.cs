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
        public int Checklogin(string TAIKHOAN, String MATKHAU)
        {
            SqlConnection conn;
            string strConnect = @"Data Source=DESKTOP-L4M7M76\SQLEXPRESS;Initial Catalog=phongmay;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();

            SqlCommand cmd = new SqlCommand("KTDANGNHAP", conn);


            cmd.Parameters.Add("@TaiKhoan", SqlDbType.Char).Value = TAIKHOAN;
            cmd.Parameters.Add("@MatKhau", SqlDbType.Char).Value = MATKHAU;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;
            int ketqua = (int)cmd.ExecuteScalar();
            return ketqua;
        }
    }
}
