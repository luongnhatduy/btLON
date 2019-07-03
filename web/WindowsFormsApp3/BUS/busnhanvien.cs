using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busnhanvien
    {
        dalnhanvien cv = new dalnhanvien();
        public DataTable select()
        {
            return cv.select();
        }
        public void insert(dtonhanvien k)
        {
            cv.insert(k);

        }
        public void update(dtonhanvien k)
        {
            cv.update(k);
        }
        public void delete(dtonhanvien k)
        {
            cv.delete(k);
        }
        public DataTable search(string k)
        {
            return cv.search(k);
        }
    }
}
