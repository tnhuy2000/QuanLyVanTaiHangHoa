﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SaoLuu_DAO
    {
        static SqlConnection con;
        // Backup
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            string sTen = "\\QuanLyVanTaiHangHoa(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLVTHH TO DISK = N'" + sDuongDan +
            sTen + "'";
            con = DataProvider.MoKetNoi();


            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
