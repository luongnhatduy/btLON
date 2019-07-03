using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalcthoadon : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_CT_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }

        public void update(dtocthoadon k)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_CT_HOADON", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MAHD", k.MAHD));
            cmd.Parameters.Add(new SqlParameter("@MASP", k.MASP));
            cmd.Parameters.Add(new SqlParameter("@SOLUONG", k.SOLUONG));

            cmd.ExecuteNonQuery();

            closeC();
        }
    }
}
