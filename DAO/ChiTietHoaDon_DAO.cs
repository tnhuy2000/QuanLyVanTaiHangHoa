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
    public class ChiTietHoaDon_DAO
    {
        static SqlConnection con;
        // Lấy danh sách tất cả 
        public static List<ChiTietHoaDon_DTO> LayDSCTHoaDon()
        {
            string sTruyVan = @"select ct.mahoadon,ct.mahanghoa,h.tenhang,ct.soluong,h.donvitinh,h.gia
            from hoadon hd, chitiethoadon ct, hanghoa h
            where hd.mahoadon=ct.mahoadon and ct.mahanghoa=h.mahanghoa
			order by ct.mahoadon ASC, h.mahanghoa ASC";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHoaDon_DTO> lst = new List<DTO.ChiTietHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDon_DTO kh = new ChiTietHoaDon_DTO();
                kh.SMahd = dt.Rows[i]["mahoadon"].ToString();
                kh.SMaHang = dt.Rows[i]["mahanghoa"].ToString();
                kh.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                kh.STenHang = dt.Rows[i]["tenhang"].ToString();
                kh.SDvt = dt.Rows[i]["donvitinh"].ToString();
                kh.SGia = int.Parse(dt.Rows[i]["gia"].ToString());

                lst.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lst;
        }
        public static bool ThemChiTietHoaDon(ChiTietHoaDon_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into chitiethoadon values('{0}','{1}','{2}')",
                kh.SMahd, kh.SMaHang, kh.SSoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaChiTietHoaDon(ChiTietHoaDon_DTO kh)
        {
            string sTruyVan = string.Format(@"update chitiethoadon set soluong = '{2}' where mahoadon = '{0}' and mahanghoa= '{1}'",
           kh.SMahd, kh.SMaHang, kh.SSoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaChiTietHoaDon(ChiTietHoaDon_DTO dx)
        {
            string sTruyVan = string.Format(@"delete from hoadon where mahoadon='{0}' and mahanghoa='{1}'", dx.SMahd,dx.SMaHang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static ChiTietHoaDon_DTO TimChiTietHoaDonTheoMaHD(string mahoadon, string mahang )
        {
            string sTruyVan = string.Format(@"select * from chitiethoadon where mahoadon='{0}' and mahanghoa ='{1}'",
            mahoadon,mahang);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            ChiTietHoaDon_DTO kh = new ChiTietHoaDon_DTO();
            kh.SMahd = dt.Rows[0]["mahoadon"].ToString();
            kh.SMaHang = dt.Rows[0]["mahanghoa"].ToString();
            kh.SSoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());
            
            DataProvider.DongKetNoi(con);
            return kh;
        }

        public static List<ChiTietHoaDon_DTO> TimChiTietHoaDonTheoMaHoaDon(string ma)
        {
            string sTruyVan = string.Format(@"select ct.mahoadon,ct.mahanghoa,ct.soluong,h.tenhang,h.donvitinh,h.gia 
                                            from chitiethoadon ct, hanghoa h 
                                            where mahoadon like N'%{0}%' and ct.mahanghoa=h.mahanghoa", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChiTietHoaDon_DTO> lstNhanVien = new List<DTO.ChiTietHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChiTietHoaDon_DTO kh = new ChiTietHoaDon_DTO();
                kh.SMahd = dt.Rows[i]["mahoadon"].ToString();
                kh.SMaHang = dt.Rows[i]["mahanghoa"].ToString();
                kh.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                kh.STenHang = dt.Rows[i]["tenhang"].ToString();
                kh.SDvt = dt.Rows[i]["donvitinh"].ToString();
                kh.SGia = int.Parse(dt.Rows[i]["gia"].ToString());

                lstNhanVien.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
