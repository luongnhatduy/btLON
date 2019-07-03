using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhaCungCapDA;

namespace NhaCungCapBUS
{
    public class NhaCungCapSer
    {
        private NHACUNGCAPDAL cmd = new NHACUNGCAPDAL();
       
        public List<nhacungcap> nhacungcap_GetAll()
        {
            return cmd.nhacungcap_getAll();
        }
    }
}
