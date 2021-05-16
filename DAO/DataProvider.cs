using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Xml;
using System.Windows.Forms;

    class DataProvider
    {
        public static string m_ConnectString;
        public static SqlConnection MoKetNoi()
        {
            string patch = Application.StartupPath + "\\cauhinh.xml";
            DocFileCauHinh(patch);
            SqlConnection KetNoi = new SqlConnection(m_ConnectString);
            KetNoi.Open();
            return KetNoi;
        }
        //doc file xml
        public static void DocFileCauHinh(string patch)
        {
            XmlTextReader reader = new XmlTextReader(patch);
            reader.MoveToElement();
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "cauhinh")
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "connectStr")
                        {
                            DataProvider.m_ConnectString = reader.ReadString();
                            break;
                        }
                    }

                }
            }
        }
        public static void DongKetNoi(SqlConnection KetNoi)
        {
            KetNoi.Close();
        }


        // Thực hiện truy vấn trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        // Thực hiện truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }

