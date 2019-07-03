using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CTHoaDonDA
{
    public class cthoadon
    {
        private string _mahd;
        private string _mahh;
        private string _dongia;
        private string _soluong;
        private string _thanhtien;

        public string mahd
        {
            get { return _mahd; }
            set { _mahd = value; }
        }
        public string mahh
        {
            get { return _mahh; }
            set { _mahh = value; }
        }
        public string dongia
        {
            get { return _dongia; }
            set { _dongia = value; }
        }
        public string soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        public string thanhtien
        {
            get { return _thanhtien; }
            set { _thanhtien = value; }
        }
        public void cthoadon_datareader(SqlDataReader dr)
        {
            _mahd = dr["MAHD"] is DBNull ? "" : dr["MAHD"].ToString();
            _mahh = dr["MAHH"] is DBNull ? "" : dr["MAHH"].ToString();
            _dongia = dr["DONGIA"] is DBNull ? "" : dr["DONGIA"].ToString();
            _soluong = dr["SOLUONG"] is DBNull ? "" : dr["SOLUONG"].ToString();
            _thanhtien = dr["THANHTIEN"] is DBNull ? "" : dr["THANHTIEN"].ToString();

        }
    }
}
