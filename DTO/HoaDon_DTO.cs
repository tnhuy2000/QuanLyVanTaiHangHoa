using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {

        private string mahoadon;
        public string SMahd
        {
            get { return mahoadon; }
            set { mahoadon = value; }
        }
        private string matuyenduong;
        public string SMatd
        {
            get { return matuyenduong; }
            set { matuyenduong = value; }
        }
        private string makh;
        public string SMakh
        {
            get { return makh; }
            set { makh = value; }
        }
        private string manv;
        public string SMaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        private DateTime ngaylap;
        public DateTime DtNgayLap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        private DateTime ngaygiao;
        public DateTime SNgayGiao
        {
            get { return ngaygiao; }
            set { ngaygiao = value; }
        }
        

        private int tonggiatri;
        public int STongGiaTri
        {
            get { return tonggiatri; }
            set { tonggiatri = value; }
        }
        private string tentuyen;
        public string STenTuyen
        {
            get { return tentuyen; }
            set { tentuyen = value; }
        }
        private string sHoTenkh;

        public string SHoTenkH
        {
            get { return sHoTenkh; }
            set { sHoTenkh = value; }
        }
        private string sHoTenNV;
        public string SHoTenNV
        {
            get { return sHoTenNV; }
            set { sHoTenNV = value; }
        }

    }
}
