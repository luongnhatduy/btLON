using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtoctphieunhap
    {
        private string _MAPN;

        public string MAPN
        {
            get { return _MAPN; }
            set { _MAPN = value; }
        }

        private string _MASP;
        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

        
        private string _SOLUONG;
        public string SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
        private string _DONGIA;
        public string DONGIA
        {
            get { return _DONGIA; }
            set { _DONGIA = value; }
        }
        public dtoctphieunhap(string pMAPN, string pMASP, string pSOLUONG, string pDONGIA)
        {
            this._MAPN = pMAPN;
            this._MASP = pMASP;
            this._SOLUONG = pSOLUONG;
            this._DONGIA = pDONGIA;
        }
    }
}
