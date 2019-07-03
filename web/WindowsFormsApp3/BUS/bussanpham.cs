using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class bussanpham
    {
        dalsanpham kh = new dalsanpham();
        public DataTable select()
        {

            return kh.select();
        }
        public void insert(dtosanpham k)
        {
            kh.insert(k);

        }
        public void update(dtosanpham k)
        {
            kh.update(k);
        }
        public void delete(dtosanpham k)
        {
            kh.delete(k);
        }
        public DataTable search(string k)
        {
            return kh.search(k);
        }
    }
}
