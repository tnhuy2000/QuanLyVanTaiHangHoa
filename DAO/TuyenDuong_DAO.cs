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
    public class TuyenDuong_DAO
    {
        static SqlConnection con;
        // Lấy danh sách tất cả 
        public static List<TuyenDuong_DTO> LayDSTuyenDuong()
        {
            string sTruyVan = "select td.*,dx.tenxe from tuyenduong td, dauxe dx where td.madauxe=dx.madauxe";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TuyenDuong_DTO> lst = new List<DTO.TuyenDuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenDuong_DTO kh = new TuyenDuong_DTO();
                kh.SMaTuyen = dt.Rows[i]["matuyenduong"].ToString();
                kh.STenTuyen = dt.Rows[i]["tentuyenduong"].ToString();
                kh.SNoiDi = dt.Rows[i]["noidi"].ToString();
                kh.SNoiDen = dt.Rows[i]["noiden"].ToString();
                kh.SDau = float.Parse(dt.Rows[i]["daudinhmuc"].ToString());
                kh.SChieuDai = float.Parse(dt.Rows[i]["chieudai"].ToString());
                kh.SMaDX = dt.Rows[i]["madauxe"].ToString();
                kh.STenXe = dt.Rows[i]["tenxe"].ToString();
                lst.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lst;
        }
        public static bool ThemTuyenDuong(TuyenDuong_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into tuyenduong values('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}')",
                kh.SMaTuyen, kh.STenTuyen, kh.SNoiDi, kh.SNoiDen, kh.SDau, kh.SChieuDai, kh.SMaDX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaTuyenDuong(TuyenDuong_DTO kh)
        {
            string sTruyVan = string.Format(@"update tuyenduong set tentuyenduong = N'{1}', noidi = N'{2}', noiden = N'{3}',daudinhmuc = '{4}',chieudai = '{5}',madauxe = '{6}' where matuyenduong = '{0}'",
           kh.SMaTuyen, kh.STenTuyen, kh.SNoiDi, kh.SNoiDen, kh.SDau, kh.SChieuDai, kh.SMaDX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaTuyenDuong(TuyenDuong_DTO dx)
        {
            string sTruyVan = string.Format(@"delete from tuyenduong where matuyenduong='{0}'", dx.SMaTuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static TuyenDuong_DTO TimTuyenDuongTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from tuyenduong where matuyenduong=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TuyenDuong_DTO kh = new TuyenDuong_DTO();
            kh.SMaTuyen = dt.Rows[0]["matuyenduong"].ToString();
            kh.STenTuyen = dt.Rows[0]["tentuyenduong"].ToString();
            kh.SNoiDi = dt.Rows[0]["noidi"].ToString();
            kh.SNoiDen = dt.Rows[0]["noiden"].ToString();
            kh.SDau = float.Parse(dt.Rows[0]["daudinhmuc"].ToString());
            kh.SChieuDai = float.Parse(dt.Rows[0]["chieudai"].ToString());
            kh.SMaDX = dt.Rows[0]["madauxe"].ToString();


            DataProvider.DongKetNoi(con);
            return kh;
        }
        public static List<TuyenDuong_DTO> TimTuyenDuongTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from tuyenduong where tentuyenduong like
            N'%{0}%' ", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TuyenDuong_DTO> lstNhanVien = new List<DTO.TuyenDuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenDuong_DTO kh = new TuyenDuong_DTO();
                kh.SMaTuyen = dt.Rows[i]["matuyenduong"].ToString();
                kh.STenTuyen = dt.Rows[i]["tentuyenduong"].ToString();
                kh.SNoiDi = dt.Rows[i]["noidi"].ToString();
                kh.SNoiDen = dt.Rows[i]["noiden"].ToString();
                kh.SDau = float.Parse(dt.Rows[i]["daudinhmuc"].ToString());
                kh.SChieuDai = float.Parse(dt.Rows[i]["chieudai"].ToString());
                kh.SMaDX = dt.Rows[i]["madauxe"].ToString();


                lstNhanVien.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static List<TuyenDuong_DTO> TimTuyenTheoMaTD(string ma)
        {
            string sTruyVan = string.Format(@"select * from tuyenduong where matuyenduong like N'%{0}%' ", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TuyenDuong_DTO> lstNhanVien = new List<DTO.TuyenDuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TuyenDuong_DTO kh = new TuyenDuong_DTO();
                kh.SMaTuyen = dt.Rows[i]["matuyenduong"].ToString();
                kh.STenTuyen = dt.Rows[i]["tentuyenduong"].ToString();
                kh.SNoiDi = dt.Rows[i]["noidi"].ToString();
                kh.SNoiDen = dt.Rows[i]["noiden"].ToString();
                kh.SDau = float.Parse(dt.Rows[i]["daudinhmuc"].ToString());
                kh.SChieuDai = float.Parse(dt.Rows[i]["chieudai"].ToString());
                kh.SMaDX = dt.Rows[i]["madauxe"].ToString();

                lstNhanVien.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
