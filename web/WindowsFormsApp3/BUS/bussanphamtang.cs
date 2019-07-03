using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class bussanphamtang
    {
        dalsanphamtang kh = new dalsanphamtang();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtosanphamtang k)
        {
            kh.insert(k);

        }
        public void update(dtosanphamtang k)
        {
            kh.update(k);
        }
        public void delete(dtosanphamtang k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
