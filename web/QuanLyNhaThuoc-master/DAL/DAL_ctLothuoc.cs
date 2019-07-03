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
    public class DAL_ctLothuoc : DBConnect
    {

        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_ctLothuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(ctLothuoc c)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_ctLothuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", c.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@mathuoc", c.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@soluong", c.Soluong));
            cmd.Parameters.Add(new SqlParameter("@ngaySX", c.NgaySX));
            cmd.Parameters.Add(new SqlParameter("@hanSD", c.HanSD));
            cmd.Parameters.Add(new SqlParameter("@gianhap", c.Gianhap));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(ctLothuoc c)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_ctLothuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", c.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@mathuoc", c.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@soluong", c.Soluong));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(ctLothuoc c)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_ctLothuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", c.Solothuoc));
           
            cmd.ExecuteNonQuery();

            closeC();
        }

    }
}
