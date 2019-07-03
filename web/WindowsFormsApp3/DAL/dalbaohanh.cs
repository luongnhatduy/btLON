using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalbaohanh :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_TT_BAOHANH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtobaohanh k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_TT_BAOHANH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@CHITIET", k.CHITIET));



            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtobaohanh k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_TT_BAOHANH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@CHITIET", k.CHITIET));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtobaohanh k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_TT_BAOHANH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_TT_BAOHANH", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
