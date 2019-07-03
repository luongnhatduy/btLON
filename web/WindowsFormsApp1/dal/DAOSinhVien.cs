using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    public class DAOSinhVien
    {
        SqlConnection conn;
        public void OpenConnect()
        {
            string strConnect = @"Data Source=DESKTOP-L4M7M76\SQLEXPRESS;Initial Catalog=Sinhvien;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        public void CloseConnect()
        {
            conn.Close();
        }

        public void ThemSinhVien(DTOSinhVien SV)
        {
            OpenConnect();
            string insert = "insert into [Sinhvien].[dbo].[SinhVien] values (@MaSV , @TenSV , @DiaChi , @SoDT)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@MaSV", SV.MaSV));
            cmd.Parameters.Add(new SqlParameter("@TenSV", SV.TenSV));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", SV.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SoDT", SV.SoDT));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void SuaSinhVien(DTOSinhVien SV)
        {
            OpenConnect();
            string edit = "update [Sinhvien].[dbo].[SinhVien] set TenSV=@TenSV,DiaChi=@DiaChi, SoDT=@SoDT where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(edit, conn);
            cmd.Parameters.Add(new SqlParameter("@MaSV", SV.MaSV));
            cmd.Parameters.Add(new SqlParameter("@TenSV", SV.TenSV));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", SV.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@SoDT", SV.SoDT));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }
        public void XoaSinhVien(string MaSV)
        {
            OpenConnect();
            string delete = "delete from [Sinhvien].[dbo].[SinhVien] where  MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@MaSV", MaSV));
            cmd.ExecuteNonQuery();
            CloseConnect();
        }

        public DataTable HienThiDS()
        {
            OpenConnect();
            DataTable dt = new DataTable();
            string ht = "select * from [Sinhvien].[dbo].[SinhVien]";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnect();
            return dt;
        }
    }
}
