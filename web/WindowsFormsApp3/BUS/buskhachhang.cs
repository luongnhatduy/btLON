using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class buskhachhang
    {
        dalkhachhang cv = new dalkhachhang();
        public DataTable select()
        {
            return cv.select();
        }
        public void insert(dtokhachhang k)
        {
            cv.insert(k);

        }
        public void update(dtokhachhang k)
        {
            cv.update(k);
        }
        public void delete(dtokhachhang k)
        {
            cv.delete(k);
        }
        public DataTable search(string k)
        {
            return cv.search(k);
        }
    }
}
