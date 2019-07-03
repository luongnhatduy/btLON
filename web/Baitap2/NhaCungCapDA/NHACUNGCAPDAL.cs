using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProvider;
using System.Data;
using System.Data.SqlClient;
namespace NhaCungCapDA
{
    public class NHACUNGCAPDAL : Sqlprovider
    {
        public List<nhacungcap> nhacungcap_getAll()
        {
            List<nhacungcap> lst = new List<nhacungcap>();
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("NhaCungCap_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nhacungcap obj = new nhacungcap();
                        obj.nhacungcap_datareader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }
        public bool nhacungcap_insert(nhacungcap data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhaCungCap_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANCC", data.mancc));
                    cmd.Parameters.Add(new SqlParameter("@TENNCC", data.tenncc));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", data.diachi));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", data.dienthoai));
                    

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool nhacungcap_update(nhacungcap data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhaCungCap_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANCC", data.mancc));
                    cmd.Parameters.Add(new SqlParameter("@TENNCC", data.tenncc));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", data.diachi));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", data.dienthoai));

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool nhacungcap_delete(nhacungcap data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhaCungCap_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANCC", data.mancc));
                    

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
