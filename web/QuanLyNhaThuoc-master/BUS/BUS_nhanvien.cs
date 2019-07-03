using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Object;
namespace BUS
{
    public class BUS_nhanvien
    {
        private DAL_nhanvien nv = new DAL_nhanvien();
        public int dangNhap(string id, string pass)
        {

            return nv.dangNhap(id,pass);
        }

        public DataTable select2(string mnv)
        {
            
            return nv.select2(mnv);

        }

        public int check_id(string id)
        {

            return nv.check_id(id);
        }
        public int check(string ma)
        {
            return nv.check(ma);
        }
        public DataTable select()
        {       
            return nv.select();
        }
        public void insert(nhanvien t)
        {
            nv.insert(t);
        }
        public void update(nhanvien t)
        {
            nv.update(t);
        }
        public void delete(nhanvien t)
        {
            nv.delete(t);
        }
        public void taotaikhoan(string id, string pass, string mnv, string quyen)
        {
            nv.taotaikhoan( id,  pass,  mnv,  quyen);
        }

        public void capquyentaikhoan(string id, string quyen)
        {
            nv.capquyentaikhoan(id, quyen);

        }
    }
}
