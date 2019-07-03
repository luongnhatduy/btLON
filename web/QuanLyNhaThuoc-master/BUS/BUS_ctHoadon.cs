using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Object;
using DAL;
using System.Data.SqlClient;
namespace BUS
{
    public class BUS_ctHoadon
    {
        DAL_ctHoadon cth = new DAL_ctHoadon();
        public DataTable select(string malo)
        {
            return cth.select(malo);

        }
        public void insert(ctHoadon ch)
        {
            cth.insert(ch);
        }
        public void update(ctHoadon ch)
        {
            cth.update(ch);
        }
        public void delete(ctHoadon ch)
        {
            cth.delete(ch);
        }

    }
}
