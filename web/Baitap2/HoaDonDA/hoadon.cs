using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HoaDonDA
{
    public class hoadon
    {
        private string _mahd;
        private string _makh;
        private string _manv;
        private string _ngaylap;
        private string _tongtien;

        public string mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string makh
        {
            get { return _makh; }
            set { _makh = value; }
        }
        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public string ngaylap
        {
            get { return _ngaylap; }
            set { _ngaylap = value; }
        }
        public string tongtien
        {
            get { return _tongtien; }
            set { _tongtien = value; }
        }
        public void hoadon_datareader(SqlDataReader dr)
        {
            _mahd = dr["MAHD"] is DBNull ? "" : dr["MAHD"].ToString();
            _makh = dr["MAKH"] is DBNull ? "" : dr["MAKH"].ToString();
            _manv = dr["MANV"] is DBNull ? "" : dr["MANV"].ToString();
            _ngaylap = dr["NGAYLAP"] is DBNull ? "" : dr["NGAYLAP"].ToString();
            _tongtien = dr["TONGTIEN"] is DBNull ? "" : dr["TONGTIEN"].ToString();

        }
    }
}
