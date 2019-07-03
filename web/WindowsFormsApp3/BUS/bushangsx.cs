using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class bushangsx
    {
        dalhangsx kh = new dalhangsx();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtohangsx k)
        {
            kh.insert(k);

        }
        public void update(dtohangsx k)
        {
            kh.update(k);
        }
        public void delete(dtohangsx k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
