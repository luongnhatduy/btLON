using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtonhacc
    {
        private string _MANCC;

        public string MANCC
        {
            get { return _MANCC; }
            set { _MANCC = value; }
        }

        private string _TENNHACC;
        public string TENNHACC
        {
            get { return _TENNHACC; }
            set { _TENNHACC = value; }
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
        
        public dtonhacc(string pMANCC, string pTENNHACC, string pDIACHI, string pSDT)
        {
            this._MANCC = pMANCC;
            this._TENNHACC = pTENNHACC;
            this._DIACHI = pDIACHI;
            this._SDT = pSDT;
        }
    }
}
