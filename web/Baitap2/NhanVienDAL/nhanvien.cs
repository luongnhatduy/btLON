using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace NhanVienDAL
{
    public class nhanvien
    {
        private string _manv;
        private string _tennv;
        private string _honv;
        private string _diachi;
        private string _ngaysinh;
        private string _gioitinh;
        private string _dienthoai;
        private string _taikhoan;
        private string _matkhau;
        private string _loainv;


        public string manv
        {
            get { return _manv; }
            set { _manv = value; }
        }
        public string tennv
        {
            get { return _tennv; }
            set { _tennv = value; }
        }
        public string honv
        {
            get { return _honv; }
            set { _honv = value; }
        }
        public string diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        public string ngaysinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value; }
        }
        public string gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string dienthoai
        {
            get { return _dienthoai; }
            set { _dienthoai = value; }
        }
        public string taikhoan
        {
            get { return _taikhoan; }
            set { _taikhoan = value; }
        }
        public string matkhau
        {
            get { return _matkhau; }
            set { _matkhau = value; }
        }
        public string loainv
        {
            get { return _loainv; }
            set { _loainv = value; }
        }
        public void nhanvien_datareader(SqlDataReader dr)
        {
            _manv = dr["MANV"] is DBNull ? "" : dr["MANV"].ToString();
            _tennv = dr["TEN"] is DBNull ? "" : dr["TEN"].ToString();
            _honv = dr["HO"] is DBNull ? "" : dr["HO"].ToString();
            _diachi = dr["DIACHI"] is DBNull ? "" : dr["DIACHI"].ToString();
            _ngaysinh = dr["NGAYSINH"] is DBNull ? "" : dr["NGAYSINH"].ToString();
            _gioitinh = dr["GIOITINH"] is DBNull ? "" : dr["GIOITINH"].ToString();
            _dienthoai = dr["DIENTHOAI"] is DBNull ? "" : dr["DIENTHOAI"].ToString();
            _taikhoan = dr["USERNAME"] is DBNull ? "" : dr["USERNAME"].ToString();
            _matkhau = dr["PASSWORDS"] is DBNull ? "" : dr["PASSWORDS"].ToString();
            _loainv = dr["LOAINV"] is DBNull ? "" : dr["LOAINV"].ToString();
        }
    }
}
