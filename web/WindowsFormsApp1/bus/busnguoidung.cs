using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dal;
namespace bus
{
    public class busnguoidung
    {
        dal_nguoidung tk = new dal_nguoidung();
        public int Checklogin(string TAIKHOAN, string MATKHAU)
        {
            return tk.Checklogin(TAIKHOAN, MATKHAU);
        }
    }
}

