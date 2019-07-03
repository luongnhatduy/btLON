using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class bushoadon
    {
        dalhoadon kh = new dalhoadon();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtohoadon k)
        {
            kh.insert(k);

        }
        public void update(dtohoadon k)
        {
            kh.update(k);
        }
        public void delete(dtohoadon k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
