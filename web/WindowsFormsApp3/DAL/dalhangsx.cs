using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalhangsx :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_HANGSX", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtohangsx k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_HANGSX", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k.MAHANGSX));
            cmd.Parameters.Add(new SqlParameter("@TENHANGSX", k.TENHANGSX));
          
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtohangsx k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_HANGSX", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k.MAHANGSX));
            cmd.Parameters.Add(new SqlParameter("@TENHANGSX", k.TENHANGSX));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtohangsx k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_HANGSX", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k.MAHANGSX));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_HANGSX", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
