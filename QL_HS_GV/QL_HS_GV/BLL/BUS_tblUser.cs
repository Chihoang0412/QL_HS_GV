using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_HS_GV.DAL;

namespace QL_HS_GV.BLL
{
    class BUS_tblUser
    {
        SQL_tblUser user = new SQL_tblUser();
        public int CheckLogin(string id, string pass)
        {
            return (int)user.CheckLogin(id, pass);
        }
    }
}
