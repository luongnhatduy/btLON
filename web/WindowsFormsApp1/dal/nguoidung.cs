using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dal
{
    class nguoidung
    {
        private string _TAIKHOAN;

        public String TAIKHOAN_
        {
            get { return _TAIKHOAN; }
            set { _TAIKHOAN = value; }
        }
        private String _MATKHAU;
        public String MATKHAU_
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }

        public nguoidung(string pTAIKHOAN, string pMATKHAU)
        {
            this.TAIKHOAN_ = pTAIKHOAN;
            this.MATKHAU_ = pMATKHAU;
        }
    }
}
