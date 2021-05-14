using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class NhomQuyen_DAO
    {
        static SqlConnection cnn = null;
        public static DataTable Load_DSCV()
        {
            DataTable dt = new DataTable();
            string select = "SELECT * FROM nhomquyenhan";
            cnn = DataProvider.MoKetNoi();
            dt = DataProvider.TruyVanLayDuLieu(select, cnn);
            DataProvider.DongKetNoi(cnn);
            return dt;
        }
    }
}
