using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HoaDonDA;
namespace HoaDonBUS
{
    public class HoaDonSer
    {
        private HOADONDAL cmd = new HOADONDAL();
       
        public List<hoadon> hoadon_GetAll()
        {
            return cmd.hoadon_getAll();
        }
    }
}
