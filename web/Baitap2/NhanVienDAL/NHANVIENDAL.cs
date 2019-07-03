using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SqlProvider;

namespace NhanVienDAL
{
    public class NHANVIENDAL : Sqlprovider
    {
        public List<nhanvien> nhanvien_getAll()
        {
            List<nhanvien> lst = new List<nhanvien>();
            using (SqlConnection conn = getConnect())
            {
                SqlCommand cmd = new SqlCommand("NhanVien_Select", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        nhanvien obj = new nhanvien();
                        obj.nhanvien_datareader(dr);
                        lst.Add(obj);
                    }
                }
            }
            return lst;
        }
        public bool nhanvien_insert(nhanvien data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhanVien_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANV", data.manv));
                    cmd.Parameters.Add(new SqlParameter("@TEN", data.tennv));
                    cmd.Parameters.Add(new SqlParameter("@HO", data.honv));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", data.diachi));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", data.ngaysinh));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", data.gioitinh));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", data.dienthoai));
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", data.taikhoan));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORDS", data.matkhau));
                    cmd.Parameters.Add(new SqlParameter("@LOAINV", data.loainv));
                    
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool nhanvien_update(nhanvien data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhanVien_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANV", data.manv));
                    cmd.Parameters.Add(new SqlParameter("@TEN", data.tennv));
                    cmd.Parameters.Add(new SqlParameter("@HO", data.honv));
                    cmd.Parameters.Add(new SqlParameter("@DIACHI", data.diachi));
                    cmd.Parameters.Add(new SqlParameter("@NGAYSINH", data.ngaysinh));
                    cmd.Parameters.Add(new SqlParameter("@GIOITINH", data.gioitinh));
                    cmd.Parameters.Add(new SqlParameter("@DIENTHOAI", data.dienthoai));
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", data.taikhoan));
                    cmd.Parameters.Add(new SqlParameter("@PASSWORDS", data.matkhau));
                    cmd.Parameters.Add(new SqlParameter("@LOAINV", data.loainv));

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool nhanvien_delete(nhanvien data)
        {
            try
            {
                using (SqlConnection conn = getConnect())
                {
                    SqlCommand cmd = new SqlCommand("NhanVien_Delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MANV", data.manv));
                    

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
