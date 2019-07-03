using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtophieunhap
    {
        private string _MAPN;

        public string MAPN
        {
            get { return _MAPN; }
            set { _MAPN = value; }
        }

        private string _NGAY;
        public string NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }

        private string _MANCC;
        public string MANCC
        {
            get { return _MANCC; }
            set { _MANCC = value; }
        }

        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }

        public dtophieunhap(string pMAPN, string pNGAY, string pMANCC, string pMANV)
        {
            this._MAPN = pMAPN;
            this._NGAY = pNGAY;
            this._MANCC = pMANCC;
            this._MANV = pMANV;
        }
    }
}




