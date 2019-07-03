using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalsanphamtang :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_SP_TANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtosanphamtang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_SP_TANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP_TANG", k.MASP_TANG));
            cmd.Parameters.Add(new SqlParameter("@TENSPT", k.TENSPT));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtosanphamtang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_SP_TANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP_TANG", k.MASP_TANG));
            cmd.Parameters.Add(new SqlParameter("@TENSPT", k.TENSPT));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtosanphamtang k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_SP_TANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP_TANG", k.MASP_TANG));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_SP_TANG", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP_TANG", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
