using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace HangHoaDA
{
    public class hanghoa
    {
        private string _mahh;
        private string _tenhh;
        private string _dvt;
        private string _loaihh;
        private string _soluong;
        private string _soluonggiam;
        private string _gia;

        public string mahh
        {
            get { return _mahh; }
            set { _mahh = value; }
        }
        public string tenhh
        {
            get { return _tenhh; }
            set { _tenhh = value; }
        }
        public string dvt
        {
            get { return _dvt; }
            set { _dvt = value; }
        }
        public string loaihh
        {
            get { return _loaihh; }
            set { _loaihh = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string soluonggiam
        {
            get { return _soluonggiam; }
            set { _soluonggiam = value; }
        }
        public string gia
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public void hanghoa_datareader(SqlDataReader dr)
        {
            _mahh = dr["MAHH"] is DBNull ? "" : dr["MAHH"].ToString();
            _tenhh = dr["TENHH"] is DBNull ? "" : dr["TENHH"].ToString();
            _dvt = dr["DVT"] is DBNull ? "" : dr["DVT"].ToString();
            _loaihh = dr["LOAIHH"] is DBNull ? "" : dr["LOAIHH"].ToString();
            _soluong = dr["SOLUONG"] is DBNull ? "" : dr["SOLUONG"].ToString();
            _soluonggiam = dr["SOLUONGGIAM"] is DBNull ? "" : dr["SOLUONGGIAM"].ToString();
            _gia = dr["GIA"] is DBNull ? "" : dr["GIA"].ToString();

        }
    }
}
