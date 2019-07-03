using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Object;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_nhaCC
    {
        DAL_nhaCC ncc = new DAL_nhaCC();
        public DataTable select()
        {

            return ncc.select();

        }
        public int check(string mnccc)
        {
            return ncc.check_mancc(mnccc);
        }
        public void insert(nhaCC n)
        {
            ncc.insert(n);

        }
        public void update(nhaCC n)
        {
            ncc.update(n);
        }
        public void delete(nhaCC n)
        {
            ncc.delete(n);
        }
    }
}
