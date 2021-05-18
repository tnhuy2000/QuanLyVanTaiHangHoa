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
    public class TaiXe_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả 
        public static List<TaiXe_DTO> LayDSTaiXe()
        {
            string sTruyVan = "select * from taixe";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiXe_DTO> lstTaiXe = new List<DTO.TaiXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiXe_DTO kh = new TaiXe_DTO();
                kh.SMaTX = dt.Rows[i]["mataixe"].ToString();
                kh.SHoTen = dt.Rows[i]["hoten"].ToString();
                kh.SCmnd = dt.Rows[i]["cmnd"].ToString();
                kh.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                
               
                lstTaiXe.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstTaiXe;
        }
        public static bool ThemTaiXe(TaiXe_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into taixe values(N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
            kh.SMaTX, kh.SHoTen, kh.SCmnd, kh.SDienThoai, kh.SDiaChi);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaTaiXe(TaiXe_DTO kh)
        {
            string sTruyVan = string.Format(@"update taixe set hoten = N'{1}', cmnd = N'{2}',dienthoai = N'{3}',diachi = N'{4}' where mataixe = N'{0}'",
            kh.SMaTX, kh.SHoTen, kh.SCmnd, kh.SDienThoai, kh.SDiaChi );
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaTaiXe(TaiXe_DTO makh)
        {
            string sTruyVan = string.Format(@"Delete from taixe where mataixe = N'{0}'", makh.SMaTX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static TaiXe_DTO TimTaiXeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from taixe where mataixe=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            TaiXe_DTO kh = new TaiXe_DTO();
            kh.SMaTX = dt.Rows[0]["mataixe"].ToString();
            kh.SHoTen = dt.Rows[0]["hoten"].ToString();
            kh.SCmnd = dt.Rows[0]["cmnd"].ToString();
            kh.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
            kh.SDiaChi = dt.Rows[0]["diachi"].ToString();
           
            

            DataProvider.DongKetNoi(con);
            return kh;
        }
        public static List<TaiXe_DTO> TimTaiXeTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from taixe where hoten like
            N'%{0}%' ", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<TaiXe_DTO> lstNhanVien = new List<DTO.TaiXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TaiXe_DTO nv = new TaiXe_DTO();
                nv.SMaTX = dt.Rows[i]["mataixe"].ToString();
                nv.SHoTen = dt.Rows[i]["hoten"].ToString();
                nv.SCmnd = dt.Rows[i]["cmnd"].ToString();
                nv.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
               
                

                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
