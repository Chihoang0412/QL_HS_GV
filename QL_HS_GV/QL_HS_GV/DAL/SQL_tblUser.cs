using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QL_HS_GV.Entities;

namespace QL_HS_GV.DAL
{
    class SQL_tblUser
    {
        KetNoiDB kn = new KetNoiDB();

        public int CheckLogin(string id , string pass)
        {
            return (int)kn.GetValue(@"select count(*) from tblUser where Username = '" + id + "' and Password = '" + pass + "'");
        }
    }
}
