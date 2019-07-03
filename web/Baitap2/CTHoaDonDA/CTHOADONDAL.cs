using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SqlProvider;
namespace CTHoaDonDA
{
    public class CTHOADONDAL : Sqlprovider
    {
        public List<cthoadon> cthoadon_getAll()
        {
            List<cthoadon> lst = new List<cthoadon>();
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("CTHoaDon_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cthoadon obj = new cthoadon();
                        obj.cthoadon_datareader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }
        public bool cthoadon_insert(cthoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("CTHoaDon_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));
                    cmd.Parameters.Add(new SqlParameter("@MAHH", data.mahh));
                    cmd.Parameters.Add(new SqlParameter("@DONGIA", data.dongia));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONG", data.soluong));
                    cmd.Parameters.Add(new SqlParameter("@THANHTIEN", data.thanhtien));                   
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool cthoadon_update(cthoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("CTHoaDon_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));
                    cmd.Parameters.Add(new SqlParameter("@MAHH", data.mahh));
                    cmd.Parameters.Add(new SqlParameter("@DONGIA", data.dongia));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONG", data.soluong));
                    cmd.Parameters.Add(new SqlParameter("@THANHTIEN", data.thanhtien));


                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool cthoadon_delete(cthoadon data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("CTHoaDon_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHD", data.mahd));
                    cmd.Parameters.Add(new SqlParameter("@MAHH", data.mahh));

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
