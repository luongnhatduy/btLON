using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busdanhmuc
    {
        daldanhmuc kh = new daldanhmuc();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtodanhmuc k)
        {
            kh.insert(k);

        }
        public void update(dtodanhmuc k)
        {
            kh.update(k);
        }
        public void delete(dtodanhmuc k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
