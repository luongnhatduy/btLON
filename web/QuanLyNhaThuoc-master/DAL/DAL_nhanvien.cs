using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Object;
namespace DAL
{
    public class DAL_nhanvien : DBConnect
    {   

        public int dangNhap(string id, string pass)
        {
            openC();
            SqlCommand cmd = new SqlCommand("checkLogin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", id));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }

        public int check(string mnv)
        {
            openC();
            SqlCommand cmd = new SqlCommand("check_nhanvien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@manv", mnv));
            int kq = (int)cmd.ExecuteScalar();


            cmd = new SqlCommand("check_nhanvien2", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@manv", mnv));
            int kq2 = (int)cmd.ExecuteScalar();

            closeC();
            return kq+kq2;
        }

        public void taotaikhoan(string id, string pass,string mnv, string quyen)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_insert_taikhoan_nhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNV", mnv));
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@password", pass));
            cmd.Parameters.Add(new SqlParameter("@quyentruycap", quyen));
            cmd.ExecuteNonQuery();
            closeC();
            
        }
        public void capquyentaikhoan(string id, string quyen)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_update_taikhoan_nhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.Parameters.Add(new SqlParameter("@quyentruycap", quyen));
            cmd.ExecuteNonQuery();
            closeC();

        }
        public int check_id(string id)
        {
            openC();
            SqlCommand cmd = new SqlCommand("checkLogin_id", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", id));
            int kq = (int)cmd.ExecuteScalar();
            closeC();
            return kq;
        }

        public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_nhanvien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }

        public DataTable select2(string mnv)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_nhanvien2", con);
            cmd.Parameters.Add(new SqlParameter("@maNV",mnv));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }

        public void insert(nhanvien t)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_insert_nhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNV", t.Manv));
            cmd.Parameters.Add(new SqlParameter("@tenNV", t.Ten));
            cmd.Parameters.Add(new SqlParameter("@diachi", t.Diachi));
            cmd.Parameters.Add(new SqlParameter("@email", t.Email));     
            cmd.Parameters.Add(new SqlParameter("@sdt", t.Sdt));     
            cmd.ExecuteNonQuery();
            closeC();
        }

        public void update(nhanvien t)
        {
            openC();
            SqlCommand cmd = new SqlCommand("sp_update_nhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNV", t.Manv));
            cmd.Parameters.Add(new SqlParameter("@tenNV", t.Ten));
            cmd.Parameters.Add(new SqlParameter("@diachi", t.Diachi));
            cmd.Parameters.Add(new SqlParameter("@email", t.Email));
            cmd.Parameters.Add(new SqlParameter("@sdt", t.Sdt));
            cmd.ExecuteNonQuery();
            closeC();
        }

        public void delete(nhanvien t)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_nhanVien", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maNV", t.Manv));
            cmd.Parameters.Add(new SqlParameter("@id", t.Taikhoan));
            cmd.ExecuteNonQuery();

            closeC();


        }

    }
}
