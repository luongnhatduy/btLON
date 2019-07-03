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
    public class DAL_thuoc:DBConnect
    {   
       
       public DataTable select()
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_select_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;
            
        }
        public DataTable search(string ten)
        {
            openC();
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_search_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@tenthuoc", ten));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            closeC();
            return tb;

        }
        public void insert(thuoc t)
        {
            openC();
           
            SqlCommand cmd = new SqlCommand("sp_insert_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mathuoc", t.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@tenthuoc", t.Tenthuoc));
            cmd.Parameters.Add(new SqlParameter("@Loaithuoc", t.Loaithuoc));
            cmd.Parameters.Add(new SqlParameter("@Congdung", t.Congdung));
            cmd.Parameters.Add(new SqlParameter("@HanSD", t.HanSD));
            cmd.Parameters.Add(new SqlParameter("@Thuocdacbiet", t.Thuocdacbiet));
            cmd.Parameters.Add(new SqlParameter("@Tacdungphu", t.Tacdungphu));
            cmd.Parameters.Add(new SqlParameter("@Chongchidinh", t.Chongchidinh));
            cmd.Parameters.Add(new SqlParameter("@Dongia", t.Dongia));
            cmd.Parameters.Add(new SqlParameter("@Donvitinh", t.Donvitinh));
            cmd.Parameters.Add(new SqlParameter("@Ghichu", t.Ghichu));
            cmd.ExecuteNonQuery();
           
            closeC();
           

        }
        
        public void update(thuoc t)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_update_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mathuoc", t.Mathuoc));
            cmd.Parameters.Add(new SqlParameter("@tenthuoc", t.Tenthuoc));
            cmd.Parameters.Add(new SqlParameter("@Loaithuoc", t.Loaithuoc));
            cmd.Parameters.Add(new SqlParameter("@Congdung", t.Congdung));
            cmd.Parameters.Add(new SqlParameter("@HanSD", t.HanSD));
            cmd.Parameters.Add(new SqlParameter("@Thuocdacbiet", t.Thuocdacbiet));
            cmd.Parameters.Add(new SqlParameter("@Tacdungphu", t.Tacdungphu));
            cmd.Parameters.Add(new SqlParameter("@Chongchidinh", t.Chongchidinh));
            cmd.Parameters.Add(new SqlParameter("@Dongia", t.Dongia));
            cmd.Parameters.Add(new SqlParameter("@Donvitinh", t.Donvitinh));
            cmd.Parameters.Add(new SqlParameter("@Ghichu", t.Ghichu));
            cmd.ExecuteNonQuery();

            closeC();


        }
        public void delete(thuoc t)
        {
            openC();

            SqlCommand cmd = new SqlCommand("sp_delete_thuoc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@mathuoc", t.Mathuoc));
            
            cmd.ExecuteNonQuery();

            closeC();


        }



    }
}
