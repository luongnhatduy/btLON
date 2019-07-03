using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace QuanLiSinhVien
{
    DALnguoidung TK = new DALnguoidung();
    public class BOSinhVien
    {
        DAOSinhVien daosinhvien = new DAOSinhVien();
        public void ThemSinhVien(DTOSinhVien SV)
        {
            daosinhvien.ThemSinhVien(SV);
        }
        public void SuaSinhVien(DTOSinhVien SV)
        {
            daosinhvien.SuaSinhVien(SV);
        }
        public void XoaSinhVien(string MaSV)
        {
            daosinhvien.XoaSinhVien(MaSV);
        }
        public DataTable HienThiDS()
        {
            return daosinhvien.HienThiDS();
        }
      
        public int Checklogin(string TAIKHOAN, string MATKHAU)
        {
            return TK.Checklogin(TAIKHOAN, MATKHAU);
        }
    }

}
