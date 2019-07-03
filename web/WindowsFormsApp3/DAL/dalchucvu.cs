using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalchucvu : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_CHUCVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtochucvu k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_CHUCVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MACV", k.MACV));
            cmd.Parameters.Add(new SqlParameter("@TENCV", k.TENCV));
            cmd.ExecuteNonQuery();
            closeC();
        }
        public void update(dtochucvu k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_CHUCVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MACV", k.MACV));
            cmd.Parameters.Add(new SqlParameter("@TENCV", k.TENCV));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtochucvu k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_CHUCVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MACV", k.MACV));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_CHUCVU", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MACV", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }



    }
}
