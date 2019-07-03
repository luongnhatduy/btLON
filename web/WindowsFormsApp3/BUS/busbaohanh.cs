using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busbaohanh
    {
        dalbaohanh kh = new dalbaohanh();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtobaohanh k)
        {
            kh.insert(k);

        }
        public void update(dtobaohanh k)
        {
            kh.update(k);
        }
        public void delete(dtobaohanh k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
