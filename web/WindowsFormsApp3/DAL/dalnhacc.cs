using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalnhacc :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_NHACC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtonhacc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_NHACC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANCC", k.MANCC));
            cmd.Parameters.Add(new SqlParameter("@TENNHACC", k.TENNHACC));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtonhacc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_NHACC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANCC", k.MANCC));
            cmd.Parameters.Add(new SqlParameter("@TENNHACC", k.TENNHACC));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtonhacc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_NHACC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANCC", k.MANCC));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_NHACC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANCC", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
