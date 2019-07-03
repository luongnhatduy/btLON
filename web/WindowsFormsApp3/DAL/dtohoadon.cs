using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtohoadon
    {
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }

        private string _NGAY;
        public string NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }

        private string _MAKHACH;
        public string MAKHACH
        {
            get { return _MAKHACH; }
            set { _MAKHACH = value; }
        }

        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }
        private string _TONGTIEN;
        public string TONGTIEN
        {
            get { return _TONGTIEN; }
            set { _TONGTIEN = value; }
        }
        private string _CHIETKHAU;
        public string CHIETKHAU
        {
            get { return _CHIETKHAU; }
            set { _CHIETKHAU = value; }
        }
        public dtohoadon(string pMAHD, string pNGAY, string pMAKHACH, string pMANV, string pTONGTIEN, string pCHIETKHAU)
        {
            this._MAHD = pMAHD;
            this._NGAY = pNGAY;
            this._MAKHACH = pMAKHACH;
            this._MANV = pMANV;
            this._TONGTIEN = pTONGTIEN;
            this._CHIETKHAU = pCHIETKHAU;
        }
    }
}
