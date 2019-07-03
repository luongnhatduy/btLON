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
    public class DAL_hoaDon : DBConnect
    {
        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_hoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public int checkhoadon(string mhd)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_check_mahoadon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maHD", mhd));

            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }
        public void insert(hoaDon h)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_insert_hoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maHD", h.MaHD));
            cmd.Parameters.Add(new SqlParameter("@maKH", h.MaKH));
            cmd.Parameters.Add(new SqlParameter("@maNV", h.MaNV));
            cmd.Parameters.Add(new SqlParameter("@ngaynhap", h.Ngaynhap));
            cmd.Parameters.Add(new SqlParameter("@tongtien", h.Tongtien));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void update(hoaDon h)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_hoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maHD", h.MaHD));
            cmd.Parameters.Add(new SqlParameter("@maKH", h.MaKH));
            cmd.Parameters.Add(new SqlParameter("@maNV", h.MaNV));
            cmd.Parameters.Add(new SqlParameter("@tongtien", h.Tongtien));

            cmd.ExecuteNonQuery();

            closeC();
        }
        public void delete(hoaDon h)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_hoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maHD", h.MaHD));
        
            cmd.ExecuteNonQuery();

            closeC();
        }
    }
}
