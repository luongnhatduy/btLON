using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class nguoiDung
    {
        private string manv;
        private string ten;
        private string quyen;
        private string tendangnhap;
        private string matkhau;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        public string Tendangnhap
        {
            get
            {
                return tendangnhap;
            }

            set
            {
                tendangnhap = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public nguoiDung(string manv, string ten, string quyen, string tendangnhap)
        {
            this.Manv = manv;
            this.Ten = ten;
            this.Quyen = quyen;
            this.Tendangnhap = tendangnhap;
        }
        public nguoiDung()
        {
            
        }

    }
}
