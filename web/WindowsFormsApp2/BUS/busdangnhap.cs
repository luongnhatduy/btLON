using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class busdangnhap
    {
        daldangnhap tk = new daldangnhap();
        public int Checklogin(string TAIKHOAN, string MATKHAU)
        {
            return tk.Checklogin(TAIKHOAN, MATKHAU);
        }
    }
}
