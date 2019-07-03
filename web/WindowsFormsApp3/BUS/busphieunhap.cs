using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busphieunhap
    {
        dalphieunhap pn = new dalphieunhap();
        public DataTable select()
        {

            return pn.select();
        }
        public void insert(dtophieunhap k)
        {
            pn.insert(k);

        }
        public void update(dtophieunhap k)
        {
            pn.update(k);
        }
        public void delete(dtophieunhap k)
        {
            pn.delete(k);
        }
        public DataTable search(string k)
        {
            return pn.search(k);
        }
    }
}