using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtoMayTinh
    {
        private string _MaMay;

        public string MaMay
        {
            get { return _MaMay; }
            set { _MaMay = value; }
        }

        private string _TenMay;
        public string TenMay
        {
            get { return _TenMay; }
            set { _TenMay = value; }
        }

        private string _CauHinh;
        public string CauHinh
        {
            get { return _CauHinh; }
            set { _CauHinh = value; }
        }

        private string _TinhTrang;
        public string TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }
        private string _MaPhong;
        public string MaPhong
        {
            get { return _MaPhong; }
            set { _MaPhong = value; }
        }
        public dtoMayTinh(string pMaMay, string pTenMay, string pCauHinh, string pTinhTrang,string pMaPhong)
        {
            this._MaMay = pMaMay;
            this._TenMay = pTenMay;
            this._CauHinh = pCauHinh;
            this._TinhTrang = pTinhTrang;
            this._MaPhong = pMaPhong;
        }
    }
}
