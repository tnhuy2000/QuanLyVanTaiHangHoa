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
    public class NguoiDung_Data
    {
        //SqlDataProvider sdp =new SqlDataProvider();
        /*
        public DataTable LayDSNguoiDungTheoUSPASS(string user, string pass)
        {
            string sql =
                "select *from nguoidung where" +
                "username=@ten and password=@pass";
            SqlCommand cmd = new SqlCommand();
            SqlParameter parten = new SqlParameter();
            parten.ParameterName = "@ten";
            parten.Value = user;
            SqlParameter parpass = new SqlParameter();
            parpass.ParameterName = "@pass";
            parpass.Value = pass;
            cmd.Parameters.Add(parten);
            cmd.Parameters.Add(parpass);
            cmd.CommandText = sql;
            sdp.Load(cmd);
            return sdp;

        }
        */
    }
}
