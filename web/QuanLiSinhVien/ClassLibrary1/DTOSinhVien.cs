using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiSinhVien
{
    public class DTOSinhVien
    {
        private string _MaSV;

        public string MaSV
        {
            get{ return _MaSV; }
            set{ _MaSV = value; }        }

        private string _TenSV;
        public string TenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }

        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SoDT;
        public string SoDT
        {
            get { return _SoDT; }
            set { _SoDT = value; }
        }
      public DTOSinhVien(string pMaSV , string pTenSV , string pDiaChi , string pSoDT)
        {
            this._MaSV = pMaSV;
            this._TenSV = pTenSV;
            this._DiaChi = pDiaChi;
            this.SoDT = pSoDT;
        }
    }
}
