using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class busnhacc
    {
        dalnhacc kh = new dalnhacc();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtonhacc k)
        {
            kh.insert(k);

        }
        public void update(dtonhacc k)
        {
            kh.update(k);
        }
        public void delete(dtonhacc k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
