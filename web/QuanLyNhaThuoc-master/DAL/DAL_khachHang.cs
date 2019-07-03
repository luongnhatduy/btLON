using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Object;
namespace DAL
{
    public class DAL_khachHang : DBConnect
    {

        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_khachHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(khachHang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_khachHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maKH", k.MaKH));
            cmd.Parameters.Add(new SqlParameter("@tenKH", k.TenKH));
            cmd.Parameters.Add(new SqlParameter("@soDT", k.SoDT));
            
         
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(khachHang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_khachHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maKH", k.MaKH));
            cmd.Parameters.Add(new SqlParameter("@tenKH", k.TenKH));
            cmd.Parameters.Add(new SqlParameter("@soDT", k.SoDT));
            

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(khachHang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_khachHang", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maKH", k.MaKH));
       
            cmd.ExecuteNonQuery();

            closeC();
        }


    }
}