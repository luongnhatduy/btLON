using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtochucvu
    {
        private string _MACV;
        public string MACV
        {
            get { return _MACV; }
            set { _MACV = value; }
        }

        private string _TENCV;
        public string TENCV
        {
            get { return _TENCV; }
            set { _TENCV = value; }
        }
        public dtochucvu(string pMACV, string pTENCV)
        {
            this._MACV = pMACV;
            this._TENCV = pTENCV;
        }
    }
}
