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
    public class BUS_ctLothuoc
    {
        DAL_ctLothuoc ct = new DAL_ctLothuoc();
        public DataTable select()
        {
            return ct.select();

        }
        public void insert(ctLothuoc c)
        {
            ct.insert(c);

        }
        public void update(ctLothuoc c)
        {
            ct.update(c);
        }
        public void delete(ctLothuoc c)
        {
            ct.delete(c);
        }
    }
}
