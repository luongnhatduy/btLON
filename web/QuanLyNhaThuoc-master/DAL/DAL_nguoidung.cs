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
    public class DAL_nguoidung:DBConnect
    {   
        
        public nguoiDung getData(string id)
        {
            openC();
            DataTable tb = new DataTable();
            nguoiDung nd = new nguoiDung();
            SqlCommand cmd = new SqlCommand("sp_checklogin_nguoidung", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            //SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            
            if (tb.Rows.Count == 0)
            {
                nd.Ten = "Admin";
                nd.Quyen = "1";
                return nd;
            }
        //    nd.Manv = tb.Rows[0]["manv"].ToString();

            nd.Ten = tb.Rows[0]["tennv"].ToString();
            nd.Tendangnhap = tb.Rows[0]["id"].ToString();
            nd.Quyen = tb.Rows[0]["quyentruycap"].ToString(); 
            nd.Manv = tb.Rows[0]["manv"].ToString();
            closeC();
            return nd;
        }

        public void changePass(string id,string pass)
        {
            openC();
            DataTable tb = new DataTable();
            nguoiDung nd = new nguoiDung();
            SqlCommand cmd = new SqlCommand("sp_checklogin_changepass", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@user", id));
            cmd.Parameters.Add(new SqlParameter("@pass", pass));
            cmd.ExecuteNonQuery();
           
            closeC();
            
        }


    }
}
