using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;

namespace DAO
{
    class DataProvide:DataTable
    {
        public static string m_ConnectString;
        private static SqlConnection m_Connection;
        private SqlCommand m_Command;
        private SqlDataAdapter m_DataAdapter;
        public static SqlConnection Connection
        {
            get { return m_Connection; }
        }
        public SqlCommand SqlCmd
        {
            get { return m_Command; }
            set { m_Command = value; }
        }
        public void CloseConnection()
        {
            m_Connection.Close();
        }
        public bool OpenConnection()
        {
            try
            {
                if (m_Connection == null)
                    m_Connection = new SqlConnection(m_ConnectString);
                if (m_Connection.State == ConnectionState.Closed)
                    m_Connection.Open();
                return true;
            }
            catch(Exception e)
            {
                m_Connection.Close();
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public DataProvide()
        {
            string patch = Application.StartupPath + "\\cauhinh.xml";
            DocFileCauHinh(patch);
        }
        public void Load(SqlCommand cmd)
        {
            m_Command = cmd;
            try
            {
                this.Clear();
                m_Command.Connection = m_Connection;
                m_DataAdapter = new SqlDataAdapter();
                m_DataAdapter.SelectCommand = m_Command;
                m_DataAdapter.Fill(this);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
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
                            DataProvide.m_ConnectString = reader.ReadString();
                            break;
                        }
                    }

                }
            }
        }
    }
}
