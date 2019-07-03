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
    public class DAL_ctHoadon : DBConnect
    {
        public DataTable select(string malo)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_ctHoadon", con);
            cmd.Parameters.Add(new SqlParameter("@maHD", malo));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(ctHoadon ch)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_ctHoadon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add(new SqlParameter("@maHD", ch.MaHD));
            cmd.Parameters.Add(new SqlParameter("@solothuoc", ch.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@mathuoc", ch.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@soluong", ch.Soluong));
            cmd.Parameters.Add(new SqlParameter("@dongia", ch.Dongia));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(ctHoadon ch)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_ctHoadon", con);
            cmd.CommandType = CommandType.StoredProcedure;
        
            cmd.Parameters.Add(new SqlParameter("@maHD", ch.MaHD));
            cmd.Parameters.Add(new SqlParameter("@solothuoc", ch.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@mathuoc", ch.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@soluong", ch.Soluong));
            cmd.Parameters.Add(new SqlParameter("@dongia", ch.Dongia));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(ctHoadon ch)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_ctHoadon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
       
            cmd.ExecuteNonQuery();

            closeC();
        }
    }
}
