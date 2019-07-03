using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalctphieunhap :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_CT_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtoctphieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_CT_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@SOLUONG", k.SOLUONG));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", k.DONGIA));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtoctphieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_CT_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@SOLUONG", k.SOLUONG));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", k.DONGIA));



            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtoctphieunhap k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_CT_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MAPN", k.MAPN));

            cmd.ExecuteNonQuery();

            closeC();
        }

        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_CT_PHIEUNHAP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAPN", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
