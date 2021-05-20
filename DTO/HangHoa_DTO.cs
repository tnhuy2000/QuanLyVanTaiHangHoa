using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_DTO
    {
        private string mahang;

        public string SMaHang
        {
            get { return mahang; }
            set { mahang = value; }
        }

        private string tenhang;

        public string STenHang
        {
            get { return tenhang; }
            set { tenhang = value; }
        }
        private string donvitinh;

        public string SDvt
        {
            get { return donvitinh; }
            set { donvitinh = value; }
        }

        private int gia;

        public int SGia
        {
            get { return gia; }
            set { gia = value; }
        }
        

    }
}
