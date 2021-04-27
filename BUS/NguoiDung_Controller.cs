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
    public class NguoiDung_Controller
    {
        NguoiDung_Data data = new NguoiDung_Data();
        //neu tra ve 0 thi xem nhu sai mat khau va user, nguoc lai tra ve quyen cua user do
        /*
        public int XuLyDangNhap(string user, string pass)
        {
            DataTable tb = data.LayDSNguoiDungTheoUSPASS(user, pass);
            if (tb.Rows.Count == 0)
                return 0;
            else return Convert.ToInt32(tb.Rows[0]["quyen"].ToString());
        }
        */
    }
}
