using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace BUS
{
    public class NhomQuyen_BUS
    {
        public static DataTable Load_DSCV()
        {
            return NhomQuyen_DAO.Load_DSCV();
        }
    }
}
