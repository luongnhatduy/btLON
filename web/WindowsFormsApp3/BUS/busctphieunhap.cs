using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busctphieunhap
    {
        dalctphieunhap pn = new dalctphieunhap();
        public DataTable select()
        {

            return pn.select();
        }
        public void insert(dtoctphieunhap k)
        {
            pn.insert(k);

        }
        public void update(dtoctphieunhap k)
        {
            pn.update(k);
        }
        public void delete(dtoctphieunhap k)
        {
            pn.delete(k);
        }
        public DataTable search(string k)
        {
            return pn.search(k);
        }
    }
}
