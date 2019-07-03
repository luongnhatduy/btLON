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
    public class BUS_donthuoc
    {
        DAL_donthuoc d = new DAL_donthuoc();
        public DataTable select(string makh)
        {

            return d.select(makh);
        }
        public void insert(donthuoc dt)
        {
            d.insert(dt);

        }
        public void update(donthuoc dt)
        {
            d.update(dt);
        }
        public void delete(donthuoc dt)
        {
            d.delete(dt);
        }
    }
}
