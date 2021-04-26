using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung_DTO
    {
        string manguoidung;
        string username;
        string password;
        int quyen;
        public string MANGUOIDUNG
        {
            get { return manguoidung; }
            set { manguoidung = value; }
        }
        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }
        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }
        public int QUYEN
        {
            get { return quyen; }
            set { quyen = value; }
        }

    }
}
