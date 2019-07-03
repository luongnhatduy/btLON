using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalkhachhang :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_KHACH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtokhachhang k)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_insert_KHACH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k.MAKHACH));
            cmd.Parameters.Add(new SqlParameter("@TENKHACH", k.TENKHACH));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));
            cmd.Parameters.Add(new SqlParameter("@SINHNHAT", k.SINHNHAT));
            cmd.ExecuteNonQuery();
            closeC();
        }
        public void update(dtokhachhang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_KHACH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k.MAKHACH));
            cmd.Parameters.Add(new SqlParameter("@TENKHACH", k.TENKHACH));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));
            cmd.Parameters.Add(new SqlParameter("@SINHNHAT", k.SINHNHAT));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtokhachhang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_KHACH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k.MAKHACH));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_KHACHHANG ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }

    }
}
