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
    public class KhachHang_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả khách hàng
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            string sTruyVan = "select * from khachhang";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<DTO.KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.SMaKH = dt.Rows[i]["makh"].ToString();
                kh.SHoTen = dt.Rows[i]["hoten"].ToString();
                kh.SDiaChi = dt.Rows[i]["diachi"].ToString();
                kh.SDienThoai = dt.Rows[i]["dienthoai"].ToString();
                kh.SCmnd = dt.Rows[i]["cmnd"].ToString();
                lstKhachHang.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstKhachHang;
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into khachhang values(N'{0}',N'{1}',N'{2}',N'{3}','{4}')",
            kh.SMaKH, kh.SHoTen, kh.SDiaChi, kh.SDienThoai, kh.SCmnd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            string sTruyVan = string.Format(@"update khachhang set hoten = N'{1}', diachi = N'{2}',dienthoai = N'{3}',cmnd = N'{4}' where manv = N'{0}'",
            kh.SMaKH, kh.SHoTen, kh.SDiaChi, kh.SDienThoai, kh.SCmnd);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaKhachHang(KhachHang_DTO makh)
        {
            string sTruyVan = string.Format(@"Delete from khachhang where makh = N'{0}'", makh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from khachhang where makh=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = dt.Rows[0]["makh"].ToString();
            kh.SHoTen = dt.Rows[0]["hoten"].ToString();
            kh.SDiaChi = dt.Rows[0]["diachi"].ToString();
            kh.SDienThoai = dt.Rows[0]["dienthoai"].ToString();
            kh.SCmnd = dt.Rows[0]["cmnd"].ToString();

            DataProvider.DongKetNoi(con);
            return kh;
        }
    }
}
