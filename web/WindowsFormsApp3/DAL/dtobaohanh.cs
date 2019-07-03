using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtobaohanh
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

        private string _NGAY;
        public string NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }

        private string _CHITIET;
        public string CHITIET
        {
            get { return _CHITIET; }
            set { _CHITIET = value; }
        }
      
        public dtobaohanh(string pMAHD, string pMASP, string pNGAY, string pCHITIET)
        {
            this._MAHD = pMAHD;
            this._MASP = pMASP;
            this._NGAY = pNGAY;
            this._CHITIET = pCHITIET;
         
        }
    }
}
