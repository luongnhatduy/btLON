using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtosanphamtang
    {
        private string _MASP_TANG;

        public string MASP_TANG
        {
            get { return _MASP_TANG; }
            set { _MASP_TANG = value; }
        }

        private string _TENSPT;
        public string TENSPT
        {
            get { return _TENSPT; }
            set { _TENSPT = value; }
        }

        private string _MASP;
        public string MASP
        {
            get { return _MASP; }
            set { _MASP = value; }
        }

      
        public dtosanphamtang(string pMASP_TANG, string pTENSPT, string pMASP)
        {
            this._MASP_TANG = pMASP_TANG;
            this._TENSPT = pTENSPT;
            this._MASP = pMASP;
           
        }
    }
}
