using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProvider;
using NhanVienDAL;
using System.Data;
using System.Data.SqlClient;
namespace NhanVien
{
    public class NhanVienSer
    {
        private NHANVIENDAL cmd = new NHANVIENDAL();
        //select
        public List<nhanvien> nhanvien_GetAll()
        {
            return cmd.nhanvien_getAll();
        }
        public bool nguoidung_CheckLogin(string taikhoan, string matkhau)
        {
            List<nhanvien> lst = new List<nhanvien>();
            lst = cmd.nhanvien_getAll();
            int soluong = lst.Count(tmp => tmp.taikhoan == taikhoan && tmp.matkhau == matkhau);
            if (soluong == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        

    }
}
