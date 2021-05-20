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
    public class HoaDon_DAO
    {
        static SqlConnection con;
        // Lấy danh sách tất cả 
        public static List<HoaDon_DTO> LayDSHoaDon()
        {
            string sTruyVan = @"select hd.*,td.tentuyenduong,kh.hoten,nv.tennv
            from hoadon hd, tuyenduong td, khachhang kh, nhanvien nv
            where hd.matuyenduong=td.matuyenduong and kh.makh=hd.makh and hd.makh=kh.makh and hd.manv=nv.manv";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lst = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO kh = new HoaDon_DTO();
                kh.SMahd = dt.Rows[i]["mahoadon"].ToString();
                kh.SMatd = dt.Rows[i]["matuyenduong"].ToString();
                kh.SMakh = dt.Rows[i]["makh"].ToString();
                kh.SMaNV = dt.Rows[i]["manv"].ToString();
                kh.DtNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                kh.DtNgayGiao = DateTime.Parse(dt.Rows[i]["ngaygiao"].ToString());
                kh.STongGiaTri = int.Parse(dt.Rows[i]["tonggiatri"].ToString());

                kh.STenTuyen = dt.Rows[i]["tentuyenduong"].ToString();
                kh.SHoTenkH = dt.Rows[i]["hoten"].ToString();
                kh.SHoTenNV = dt.Rows[i]["tennv"].ToString();
                lst.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lst;
        }
        public static bool ThemHoaDon(HoaDon_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into hoadon values('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}')",
                kh.SMahd, kh.SMatd, kh.SMakh, kh.SMaNV,kh.DtNgayLap.ToString("yyyy/MM/dd"), kh.DtNgayGiao.ToString("yyyy/MM/dd"), kh.STongGiaTri);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaHoaDon(HoaDon_DTO kh)
        {
            string sTruyVan = string.Format(@"update hoadon set matuyenduong = N'{1}', makh = N'{2}', manv = N'{3}',ngaylap = '{4}',ngaygiao = '{5}',tonggiatri = '{6}' where mahoadon = '{0}'",
           kh.SMahd, kh.SMatd, kh.SMakh, kh.SMaNV, kh.DtNgayLap.ToString("yyyy/MM/dd"), kh.DtNgayGiao.ToString("yyyy/MM/dd"), kh.STongGiaTri);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHoaDon(HoaDon_DTO dx)
        {
            string sTruyVan = string.Format(@"delete from hoadon where mahoadon='{0}'", dx.SMahd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahoadon=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HoaDon_DTO kh = new HoaDon_DTO();
            kh.SMahd = dt.Rows[0]["mahoadon"].ToString();
            kh.SMatd = dt.Rows[0]["matuyenduong"].ToString();
            kh.SMakh = dt.Rows[0]["makh"].ToString();
            kh.SMaNV = dt.Rows[0]["manv"].ToString();
            kh.DtNgayLap = DateTime.Parse(dt.Rows[0]["ngaylap"].ToString());
            kh.DtNgayGiao = DateTime.Parse(dt.Rows[0]["ngaygiao"].ToString());
            kh.STongGiaTri = int.Parse(dt.Rows[0]["tonggiatri"].ToString());


            DataProvider.DongKetNoi(con);
            return kh;
        }
        
        public static List<HoaDon_DTO> TimHoaDonTheoMaHD(string ma)
        {
            string sTruyVan = string.Format(@"select * from hoadon where mahoadon like N'%{0}%' ", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstNhanVien = new List<DTO.HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO kh = new HoaDon_DTO();
                kh.SMahd = dt.Rows[i]["mahoadon"].ToString();
                kh.SMatd = dt.Rows[i]["matuyenduong"].ToString();
                kh.SMakh = dt.Rows[i]["makh"].ToString();
                kh.SMaNV = dt.Rows[i]["manv"].ToString();
                kh.DtNgayLap = DateTime.Parse(dt.Rows[i]["ngaylap"].ToString());
                kh.DtNgayGiao = DateTime.Parse(dt.Rows[i]["ngaygiao"].ToString());
                kh.STongGiaTri = int.Parse(dt.Rows[i]["tonggiatri"].ToString());


                lstNhanVien.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
