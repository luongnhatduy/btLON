using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtohangsx
    {
        private string _MAHANGSX;

        public string MAHANGSX
        {
            get { return _MAHANGSX; }
            set { _MAHANGSX = value; }
        }

        private string _TENHANGSX;
        public string TENHANGSX
        {
            get { return _TENHANGSX; }
            set { _TENHANGSX = value; }
        }

        public dtohangsx(string pMAHANGSX, string pTENHANGSX)
        {
            this._MAHANGSX = pMAHANGSX;
            this._TENHANGSX = pTENHANGSX;
           
        }
    }
}
