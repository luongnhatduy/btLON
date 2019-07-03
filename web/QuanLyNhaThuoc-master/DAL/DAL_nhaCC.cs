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
    public class DAL_nhaCC : DBConnect
    {
        public int check_mancc(string mancc)
        {
            openC();
            SqlCommand cmd = new SqlCommand("check_mancc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNCC", mancc));
            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_nhaCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert (nhaCC n)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_nhaCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNCC", n.MaNCC));
            cmd.Parameters.Add(new SqlParameter("@tenNCC", n.TenNCC));
            cmd.Parameters.Add(new SqlParameter("@diachi", n.Diachi));
            cmd.Parameters.Add(new SqlParameter("@sodt", n.Sodt));
            cmd.Parameters.Add(new SqlParameter("@email", n.Email));
            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update (nhaCC n)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_nhaCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNCC", n.MaNCC));
            cmd.Parameters.Add(new SqlParameter("@tenNCC", n.TenNCC));
            cmd.Parameters.Add(new SqlParameter("@diachi", n.Diachi));
            cmd.Parameters.Add(new SqlParameter("@sodt", n.Sodt));
            cmd.Parameters.Add(new SqlParameter("@email", n.Email));
            cmd.ExecuteNonQuery();
            closeC();


        }
        public void delete (nhaCC n)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_nhaCC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNCC", n.MaNCC));
            
            cmd.ExecuteNonQuery();


            closeC();
        }
    }
}