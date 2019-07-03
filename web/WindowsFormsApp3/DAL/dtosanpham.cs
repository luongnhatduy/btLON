using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtosanpham
    {
        private string _MASP;

        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        private string _TENSP;
        public string TENSP
        {
            get { return _TENSP; }
            set { _TENSP = value; }
        }

        private string _DONGIA;
        public string DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }

        private string _MADM;
        public string MADM
        {
            get { return _MADM; }
            set { _MADM = value; }
        }
        private string _MAHANGSX;
        public string MAHANGSX
        {
            get { return _MAHANGSX; }
            set { _MAHANGSX = value; }
        }
        private string _BAOHANH;
        public string BAOHANH
        {
            get { return _BAOHANH; }
            set { _BAOHANH = value; }
        }
        public dtosanpham(string pMASP, string pTENSP, string pDONGIA, string pMADM, string pMAHANGSX,string pBAOHANH)
        {
            this._MASP = pMASP;
            this._TENSP = pTENSP;
            this._DONGIA = pDONGIA;
            this._MADM = pMADM;
            this._MAHANGSX = pMAHANGSX;
            this._BAOHANH = pBAOHANH;
        }
    }
}
