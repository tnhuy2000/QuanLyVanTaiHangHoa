using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenDuong_DTO
    {

        private string matuyen;
        public string SMaTuyen
        {
            get { return matuyen; }
            set { matuyen = value; }
        }
        private string tentuyen;
        public string STenTuyen
        {
            get { return tentuyen; }
            set { tentuyen = value; }
        }

        private string noidi;
        public string SNoiDi
        {
            get { return noidi; }
            set { noidi = value; }
        }
        private string noiden;
        public string SNoiDen
        {
            get { return noiden; }
            set { noiden = value; }
        }

        
        private float daudinhmuc;
        public float SDau
        {
            get { return daudinhmuc; }
            set { daudinhmuc = value; }
        }
        private float chieudai;
        public float SChieuDai
        {
            get { return chieudai; }
            set { chieudai = value; }
        }

        private string smadauxe;
        public string SMaDX
        {
            get { return smadauxe; }
            set { smadauxe = value; }
        }

        private string stenxe;
        public string STenXe
        {
            get { return stenxe; }
            set { stenxe = value; }
        }
    }
}
