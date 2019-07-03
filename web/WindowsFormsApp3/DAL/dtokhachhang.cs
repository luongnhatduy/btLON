using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtokhachhang
    {
        private string _MAKHACH;

        public string MAKHACH
        {
            get { return _MAKHACH; }
            set { _MAKHACH = value; }
        }

        private string _TENKHACH;
        public string TENKHACH
        {
            get { return _TENKHACH; }
            set { _TENKHACH = value; }
        }

        private string _DIACHI;
        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }

        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _SINHNHAT;
        public string SINHNHAT
        {
            get { return _SINHNHAT; }
            set { _SINHNHAT = value; }
        }
        
        public dtokhachhang(string pMAKHACH, string pTENKHACH, string pDIACHI, string pSDT, string pSINHNHAT)
        {
            this._MAKHACH = pMAKHACH;
            this._TENKHACH = pTENKHACH;
            this._DIACHI = pDIACHI;
            this._SDT = pSDT;
            this._SINHNHAT = pSINHNHAT;
          
        }
    }
}
