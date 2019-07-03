using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HangHoaDA;
using System.Data;
using System.Data.SqlClient;
using SqlProvider;
namespace HangHoaBUS
{
    public class HangHoaSer
    {
        private HANGHOADAL cmd = new HANGHOADAL();
        //select
        public List<hanghoa> hanghoa_GetAll()
        {
            return cmd.hanghoa_getAll();
        }
    }
}
