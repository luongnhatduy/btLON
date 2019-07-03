using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dtodangnhap
    {
        private string _ID;

        public String ID_
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String _PASS;
        public String PASS_
        {
            get { return _PASS; }
            set { _PASS = value; }
        }

        public dtodangnhap(string pID, string pPASS)
        {
            this.ID_ = pID;
            this.PASS_ = pPASS;
        }
    }
}
