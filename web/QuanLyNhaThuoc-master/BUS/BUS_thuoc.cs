using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Object;
using DAL;

namespace BUS
{
    public class BUS_thuoc
    {
        DAL_thuoc thuoc = new DAL_thuoc();
        public DataTable select()
        {
            
            return thuoc.select();
        }
        public DataTable search(string ten)
        {

            return thuoc.search(ten);
        }
        public void insert(thuoc t)
        {
            thuoc.insert(t);
        }
        public void update(thuoc t)
        {
            thuoc.update(t);
        }
        public void delete(thuoc t)
        {
            thuoc.delete(t);
        }
    }
}
