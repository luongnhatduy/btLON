using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalsanpham :DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_TT_SANPHAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtosanpham k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_TT_SANPHAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@TENSP", k.TENSP));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", k.DONGIA));
            cmd.Parameters.Add(new SqlParameter("@MADM", k.MADM));
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k.MAHANGSX));
            cmd.Parameters.Add(new SqlParameter("@BAOHANH", k.BAOHANH));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtosanpham k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_TT_SANPHAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@TENSP", k.TENSP));
            cmd.Parameters.Add(new SqlParameter("@DONGIA", k.DONGIA));
            cmd.Parameters.Add(new SqlParameter("@MADM", k.MADM));
            cmd.Parameters.Add(new SqlParameter("@MAHANGSX", k.MAHANGSX));
            cmd.Parameters.Add(new SqlParameter("@BAOHANH", k.BAOHANH));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtosanpham k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_TT_SANPHAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_SANPHAM", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MASP", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
