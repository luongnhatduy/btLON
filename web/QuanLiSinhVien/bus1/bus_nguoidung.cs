using QuanLiSinhVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace bus1
{
     public class bus_nguoidung
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
           

            public int Checklogin(string TAIKHOAN, string MATKHAU)
            {
                return Checklogin(TAIKHOAN, MATKHAU);
            }
        }

    }


