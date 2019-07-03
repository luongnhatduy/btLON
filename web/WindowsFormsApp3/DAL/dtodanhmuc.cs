using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtodanhmuc
    {
        private string _MADM;

        public string MADM
        {
            get { return _MADM; }
            set { _MADM = value; }
        }

        private string _TENDM;
        public string TENDM
        {
            get { return _TENDM; }
            set { _TENDM = value; }
        }

        
        public dtodanhmuc(string pMADM, string pTENDM)
        {
            this._MADM = pMADM;
            this._TENDM = pTENDM;
          
        }
    }
}
