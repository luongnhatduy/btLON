using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtocthoadon
    {
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
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


        public dtocthoadon(string pMAHD, string pMASP, string pSOLUONG)
        {
            this._MAHD = pMAHD;
            this._MASP = pMASP;
            this._SOLUONG = pSOLUONG;

        }
    }
}
