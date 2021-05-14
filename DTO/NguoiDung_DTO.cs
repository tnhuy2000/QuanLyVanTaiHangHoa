using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung_DTO
    {
        public string tendangnhap;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }


        public string matkhau;
        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }
        public string maquyen;
        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
    }
}
