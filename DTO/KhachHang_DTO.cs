using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string sMaKH;
        private string sHoTen;
        private string sDiaChi;
        private string sDienThoai;
        private string sCmnd;
        public string SMaKH
        {
            get { return sMaKH; }
            set { sMaKH = value; }
        }

        public string SHoTen
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }

        public string SDiaChi
        {
            get { return sDiaChi; }
            set { sDiaChi = value; }
        }

        public string SDienThoai
        {
            get { return sDienThoai; }
            set { sDienThoai = value; }
        }

        public string SCmnd
        {
            get { return sCmnd; }
            set { sCmnd = value; }
        }


    }
}
