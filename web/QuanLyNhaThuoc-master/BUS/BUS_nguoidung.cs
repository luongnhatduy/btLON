using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Object;
using DAL;


namespace BUS
{
    public class BUS_nguoidung
    {
        DAL_nguoidung nd = new DAL_nguoidung();
        public nguoiDung getData(string id)
        {
            
            return nd.getData(id);
        }
        public void changePass(string id, string pass)
        {
            nd.changePass(id, pass);

            
        }
    }
}
