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
    public class DAL_loThuoc : DBConnect
    {
        public int checkmalo(string malo)
        {
            openC();
            SqlCommand cmd = new SqlCommand("check_solothuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", malo));

            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_loThuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public DataTable select_banra()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_lothuoc_Banra", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public DataTable select2()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_loThuoc2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(loThuoc l)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_loThuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", l.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", l.Ngaynhap));
            cmd.Parameters.Add(new SqlParameter("@maNV", l.Manv));
            cmd.Parameters.Add(new SqlParameter("@mancc", l.Mancc));


            cmd.ExecuteNonQuery();

            closeC();
        }



        public void update(loThuoc l)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_loThuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", l.Solothuoc));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", l.Ngaynhap));
            cmd.Parameters.Add(new SqlParameter("@maNV", l.Ngaynhap));
            cmd.Parameters.Add(new SqlParameter("@mancc", l.Mancc));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(loThuoc l)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_loThuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@solothuoc", l.Solothuoc));

            //cmd.ExecuteNonQuery();

            closeC();
        }
    }

}
