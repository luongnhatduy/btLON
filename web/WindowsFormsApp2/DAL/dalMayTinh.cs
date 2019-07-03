using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalMayTinh
    {
        SqlConnection conn;
        public void OpenConnect()
        {
            string strConnect = @"Data Source=DESKTOP-L4M7M76\SQLEXPRESS;Initial Catalog=phongmay;Integrated Security=True";
            conn = new SqlConnection(strConnect);
            conn.Open();
        }
        public void CloseConnect()
        {
            conn.Close();
        }

        
        public string SuaMayTinh(dtoMayTinh MT)
        {
            try
            {
                OpenConnect();
                string SUA = String.Format("SUA_MAYTINH", MT.MaMay, MT.TenMay, MT.CauHinh, MT.TinhTrang, MT.MaPhong);
                SqlCommand cmd = new SqlCommand(SUA, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAMAY", SqlDbType.Char).Value = MT.MaMay;
                cmd.Parameters.Add("@TENMAY", SqlDbType.Char).Value = MT.TenMay;
                cmd.Parameters.Add("@CAUHINH", SqlDbType.Char).Value = MT.CauHinh;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.Char).Value = MT.TinhTrang;
                cmd.Parameters.Add("@MAPHONG", SqlDbType.Char).Value = MT.MaPhong;

                return cmd.ExecuteNonQuery() > 0 ? "TRUE" : "FALSE";
            }
            catch (Exception E)
            {
                return E.Message;
            }
        }

        public string ThemMayTinh(dtoMayTinh MT)
        {
            try
            {
                OpenConnect();
                string THEM = String.Format("THEM_MAYTINH", MT.MaMay, MT.TenMay, MT.CauHinh, MT.TinhTrang, MT.MaPhong);
                SqlCommand cmd = new SqlCommand(THEM, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAMAY", SqlDbType.Char).Value = MT.MaMay;
                cmd.Parameters.Add("@TENMAY", SqlDbType.Char).Value = MT.TenMay;
                cmd.Parameters.Add("@CAUHINH", SqlDbType.Char).Value = MT.CauHinh;
                cmd.Parameters.Add("@TINHTRANG", SqlDbType.Char).Value = MT.TinhTrang;
                cmd.Parameters.Add("@MAPHONG", SqlDbType.Char).Value = MT.MaPhong;

                return cmd.ExecuteNonQuery() > 0 ? "TRUE" : " FALSE";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string XoaMayTinh(dtoMayTinh pMAMAY)
        {
            try
            {
                OpenConnect();
                string XOA = string.Format("XAO_MAYTINH", pMAMAY);
                SqlCommand cmd = new SqlCommand(XOA, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MAMAY", SqlDbType.Char).Value = pMAMAY;
                return cmd.ExecuteNonQuery() > 0 ? "TRUE" : "FALSE";

            }
            catch (Exception E)
            {
                return E.Message;
            }
        }
        public DataTable HienThiDS()
        {
            OpenConnect();
            DataTable dt = new DataTable();
            string ht = "select * from [phongmay].[dbo].[MayTinh]";
            SqlCommand cmd = new SqlCommand(ht, conn);
            dt.Load(cmd.ExecuteReader());
            CloseConnect();
            return dt;
        }

    }
    
}













