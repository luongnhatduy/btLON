using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTHoaDonDA;
using SqlProvider;
namespace CTHoaDonBUS
{
    public class CTHoaDonSer
    {
        private CTHOADONDAL cmd = new CTHOADONDAL();
        //select
        public List<cthoadon> cthoadon_GetAll()
        {
            return cmd.cthoadon_getAll();
        }
    }
}
