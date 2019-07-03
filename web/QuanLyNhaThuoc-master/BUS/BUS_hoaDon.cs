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
    public class BUS_hoaDon
    {
        DAL_hoaDon hd = new DAL_hoaDon();
        public DataTable select()
        {
            return hd.select();

        }
        public int checkhoadon(string mhd)
        {
            return hd.checkhoadon(mhd);
        }
        public void insert(hoaDon h)
        {
            hd.insert(h);
        }
        public void update(hoaDon h)
        {
            hd.update(h);
        }
        public void delete(hoaDon h)
        {
            hd.delete(h);
        }
    }
}
