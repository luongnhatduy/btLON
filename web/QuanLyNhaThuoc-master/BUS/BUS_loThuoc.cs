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
    public class BUS_loThuoc
    {
        DAL_loThuoc lt = new DAL_loThuoc();
        public DataTable select()
        {
            return lt.select();

        }
        public DataTable select_banra()
        {
            return lt.select_banra();

        }
        public int check(string ma)
        {
            return lt.checkmalo(ma);
        }
        public DataTable select2()
        {
            return lt.select2();

        }
        public void insert(loThuoc l)
        {
            lt.insert(l);
        }
        public void update(loThuoc l)
        {
            lt.update(l);
        }
        public void delete(loThuoc l)
        {
            lt.delete(l);
        }

    }
}
