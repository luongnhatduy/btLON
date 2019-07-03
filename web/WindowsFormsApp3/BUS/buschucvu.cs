using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class buschucvu
    {
        dalchucvu cv = new dalchucvu();
        public DataTable select()
        {
            return cv.select();
        }
        public void insert(dtochucvu k)
        {
            cv.insert(k);

        }
        public void update(dtochucvu k)
        {
            cv.update(k);
        }
        public void delete(dtochucvu k)
        {
            cv.delete(k);
        }
        public DataTable search(string k)
        {
            return cv.search(k);
        }
    }
}
