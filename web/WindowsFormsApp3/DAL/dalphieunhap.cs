using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalphieunhap : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtophieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@MANCC", k.MANCC));
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtophieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@MANCC", k.MANCC));
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtophieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
