using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtonhanvien
    {
     
        private string _MANV;
        public string MANV
        {
            get { return _MANV; }
            set { _MANV = value; }
        }

        private string _TENNV;
        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
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
        private string _MACV;
        public string MACV
        {
            get { return _MACV; }
            set { _MACV = value; }
        }
        public dtonhanvien(string pMANV, string pTENNV, string pDIACHI, string pSDT, string pMACV)
        {
            this._MANV = pMANV;
            this._TENNV = pTENNV;
            this._DIACHI = pDIACHI;
            this._SDT = pSDT;
            this._MACV = pMACV;
        }
    }
}
