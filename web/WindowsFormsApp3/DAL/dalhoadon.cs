using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalhoadon : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtohoadon k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k.MAKHACH));
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));
            cmd.Parameters.Add(new SqlParameter("@TONGTIEN", k.TONGTIEN));
            cmd.Parameters.Add(new SqlParameter("@CHIETKHAU", k.CHIETKHAU));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(dtohoadon k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));
            cmd.Parameters.Add(new SqlParameter("@NGAY", k.NGAY));
            cmd.Parameters.Add(new SqlParameter("@MAKHACH", k.MAKHACH));
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));
            cmd.Parameters.Add(new SqlParameter("@TONGTIEN", k.TONGTIEN));
            cmd.Parameters.Add(new SqlParameter("@CHIETKHAU", k.CHIETKHAU));


            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtohoadon k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }
    }
}
