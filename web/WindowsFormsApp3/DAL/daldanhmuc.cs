using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class daldanhmuc :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_DANHMUC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtodanhmuc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_DANHMUC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADM", k.MADM));
            cmd.Parameters.Add(new SqlParameter("@TENDM", k.TENDM));
      


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtodanhmuc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_DANHMUC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADM", k.MADM));
            cmd.Parameters.Add(new SqlParameter("@TENDM", k.TENDM));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtodanhmuc k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_DANHMUC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADM", k.MADM));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_DANHMUC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MADM", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
