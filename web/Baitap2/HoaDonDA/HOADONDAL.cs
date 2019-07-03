using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SqlProvider;
namespace HoaDonDA
{
    public class HOADONDAL : Sqlprovider
    {
        public List<hoadon> hoadon_getAll()
        {
            List<hoadon> lst = new List<hoadon>();
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("HoaDon_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        hoadon obj = new hoadon();
                        obj.hoadon_datareader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
       }
        public bool hoadon_insert(hoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HoaDon_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));
                    cmd.Parameters.Add(new SqlParameter("@MAKH", data.makh));
                    cmd.Parameters.Add(new SqlParameter("@MANV", data.manv));
                    cmd.Parameters.Add(new SqlParameter("@NGAYLAP", data.ngaylap));
                    cmd.Parameters.Add(new SqlParameter("@TONGTIEN", data.tongtien));

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool hoadon_update(hoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HoaDon_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));
                    cmd.Parameters.Add(new SqlParameter("@MAKH", data.makh));
                    cmd.Parameters.Add(new SqlParameter("@MANV", data.manv));
                    cmd.Parameters.Add(new SqlParameter("@NGAYLAP", data.ngaylap));
                    cmd.Parameters.Add(new SqlParameter("@TONGTIEN", data.tongtien));
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool hoadon_delete(hoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HoaDon_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));


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
