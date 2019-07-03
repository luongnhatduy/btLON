using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalnhanvien : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_NHANVIEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(dtonhanvien k)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_insert_NHANVIEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));
            cmd.Parameters.Add(new SqlParameter("@TENNV", k.TENNV));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));
            cmd.Parameters.Add(new SqlParameter("@MACV", k.MACV));
            cmd.ExecuteNonQuery();
            closeC();
        }
        public void update(dtonhanvien k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_NHANVIEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));
            cmd.Parameters.Add(new SqlParameter("@TENNV", k.TENNV));
            cmd.Parameters.Add(new SqlParameter("@DIACHI", k.DIACHI));
            cmd.Parameters.Add(new SqlParameter("@SDT", k.SDT));
            cmd.Parameters.Add(new SqlParameter("@MACV", k.MACV));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(dtonhanvien k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_NHANVIEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", k.MANV));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public DataTable search(string k)
        {
            openC();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_NHANVIEN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MANV", k));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            closeC();
            return dt;
        }

        

    }
}
