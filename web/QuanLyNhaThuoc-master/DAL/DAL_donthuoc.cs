using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Object;
namespace DAL
{
    public class DAL_donthuoc : DBConnect
    {
        public DataTable select(string makh)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_donthuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@makh", makh));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(donthuoc dt)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_donthuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madon", dt.Madon));
            cmd.Parameters.Add(new SqlParameter("@tendon", dt.Tendon));
            cmd.Parameters.Add(new SqlParameter("@ghichu", dt.Ghichu));
            cmd.Parameters.Add(new SqlParameter("@anh", dt.Anh));
            cmd.Parameters.Add(new SqlParameter("@ngay", dt.Ngay));
            cmd.Parameters.Add(new SqlParameter("@maKH", dt.MaKH));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(donthuoc dt)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_donthuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madon", dt.Madon));
            cmd.Parameters.Add(new SqlParameter("@tendon", dt.Tendon));
            cmd.Parameters.Add(new SqlParameter("@ghichu", dt.Ghichu));
            cmd.Parameters.Add(new SqlParameter("@anh", dt.Anh));
            cmd.Parameters.Add(new SqlParameter("@ngay", dt.Ngay));
            cmd.Parameters.Add(new SqlParameter("@maKH", dt.MaKH));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(donthuoc dt)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_donthuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@madon", dt.Madon));
           

            cmd.ExecuteNonQuery();

            closeC();
        }
    }
}
