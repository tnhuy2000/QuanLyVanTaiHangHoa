using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }

        private string sHoTen;

        public string SHoTen
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }

        

        private DateTime dtNgaySinh;

        public DateTime DtNgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
        }

        private string sPhai;

        public string SPhai
        {
            get { return sPhai; }
            set { sPhai = value; }
        }
        private string sdt;

        public string SSdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string diachi;

        public string SDiaChi
        {
            get { return diachi; }
            set { diachi = value; }
        }

        private string smaquyen;

        public string SMaQuyen
        {
            get { return smaquyen; }
            set { smaquyen = value; }
        }
        private string stenquyen;
        public string STenQuyen
        {
            get { return stenquyen; }
            set { stenquyen = value; }
        }
    }
}
