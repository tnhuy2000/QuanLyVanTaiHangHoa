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
        static SqlConnection con;
        public static List<NhomQuyen_DTO> LayQuyen()
        {
            string sTruyVan = "select * from nhomquyenhan";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhomQuyen_DTO> lstNhomQuyen = new List<NhomQuyen_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhomQuyen_DTO q = new NhomQuyen_DTO();
                q.Maquyen = dt.Rows[i]["maquyen"].ToString();
                q.Tenquyen = dt.Rows[i]["tenquyen"].ToString();
               
                lstNhomQuyen.Add(q);
            }
            DataProvider.DongKetNoi(con);
            return lstNhomQuyen;
        }

        public static string LayTenQuyenTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select tenquyen from nhomquyenhan where maquyen=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.DongKetNoi(con);
                return null;
            }

            DataProvider.DongKetNoi(con);
            return dt.Rows[0]["tenquyen"].ToString();
        }
    }
}
