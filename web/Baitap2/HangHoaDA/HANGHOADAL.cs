using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProvider;
using System.Data.SqlClient;
using System.Data;
namespace HangHoaDA
{
    public class HANGHOADAL : Sqlprovider
    {
        public List<hanghoa> hanghoa_getAll()
        {
            List<hanghoa> lst = new List<hanghoa>();
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("NhaCungCap_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        hanghoa obj = new hanghoa();
                        obj.hanghoa_datareader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }

        public bool hanghoa_insert(hanghoa data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HangHoa_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHH", data.mahh));
                    cmd.Parameters.Add(new SqlParameter("@TENHH", data.tenhh));
                    cmd.Parameters.Add(new SqlParameter("@DVT", data.dvt));
                    cmd.Parameters.Add(new SqlParameter("@LOAIHH", data.loaihh));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONG", data.soluong));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONGGIAM", data.soluonggiam));
                    cmd.Parameters.Add(new SqlParameter("@GIA", data.gia));


                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool hanghoa_update(hanghoa data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HangHoa_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MAHH", data.mahh));
                    cmd.Parameters.Add(new SqlParameter("@TENHH", data.tenhh));
                    cmd.Parameters.Add(new SqlParameter("@DVT", data.dvt));
                    cmd.Parameters.Add(new SqlParameter("@LOAIHH", data.loaihh));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONG", data.soluong));
                    cmd.Parameters.Add(new SqlParameter("@SOLUONGGIAM", data.soluonggiam));
                    cmd.Parameters.Add(new SqlParameter("@GIA", data.gia));


                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool hanghoa_delete(hanghoa data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("HangHoa_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
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
