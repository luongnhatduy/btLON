using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class buscthoadon
    {
        dalcthoadon cv = new dalcthoadon();
        public DataTable select()
        {
            return cv.select();
        }
      
        public void update(dtocthoadon k)
        {
            cv.update(k);
        }
       
    }
}
