using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace NhaCungCapDA
{
    public class nhacungcap
    {
        private string _mancc;
        private string _tenncc;
        private string _diachi;
        private string _dienthoai;

        public string mancc
        {
            get { return _mancc; }
            set { _mancc = value; }
        }
        public string tenncc
        {
            get { return _tenncc; }
            set { _tenncc = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }

        public void nhacungcap_datareader(SqlDataReader dr)
        {
            _mancc = dr["MANCC"] is DBNull ? "" : dr["MANCC"].ToString();
            _tenncc = dr["TENNCC"] is DBNull ? "" : dr["TENNCC"].ToString();
            _diachi = dr["DIACHI"] is DBNull ? "" : dr["DIACHI"].ToString();
            _dienthoai = dr["DIENTHOAI"] is DBNull ? "" : dr["DIENTHOAI"].ToString();
            
        }
    }
}
