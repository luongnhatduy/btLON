using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class busMayTinh
    {
        dalMayTinh maytinh = new dalMayTinh();
     
        public string ThemMayTinh(dtoMayTinh pMAYTINH)
        {
            return maytinh.ThemMayTinh(pMAYTINH);
        }
        public string XoaMayTinh(dtoMayTinh pMAMAY)
        {
            return maytinh.XoaMayTinh(pMAMAY);
        }
        public string SuaMayTinh(dtoMayTinh pMAYTINH)
        {
            return maytinh.SuaMayTinh(pMAYTINH);
        }
        public DataTable HienThiDS()
        {
            return maytinh.HienThiDS();
        }
    }
}
