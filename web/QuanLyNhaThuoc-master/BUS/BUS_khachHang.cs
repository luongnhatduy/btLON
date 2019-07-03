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
    public class BUS_khachHang
    {
        DAL_khachHang kh = new DAL_khachHang();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(khachHang k)
        {
            kh.insert(k);

        }
        public void update(khachHang k)
        {
            kh.update(k);
        }
        public void delete(khachHang k)
        {
            kh.delete(k);
        }
    }
}
