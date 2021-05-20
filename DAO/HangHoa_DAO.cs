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
    public class HangHoa_DAO
    {
        static SqlConnection con;

        // Lấy danh sách tất cả 
        public static List<HangHoa_DTO> LayDSHangHoa()
        {
            string sTruyVan = "select * from hanghoa";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<DTO.HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO kh = new HangHoa_DTO();
                kh.SMaHang = dt.Rows[i]["mahanghoa"].ToString();
                kh.STenHang = dt.Rows[i]["tenhang"].ToString();
                kh.SDvt = dt.Rows[i]["donvitinh"].ToString();
                kh.SGia = int.Parse(dt.Rows[i]["gia"].ToString());
                kh.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());


                lstHangHoa.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstHangHoa;
        }
        public static bool ThemHangHoa(HangHoa_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into hanghoa values(N'{0}',N'{1}',N'{2}','{3}','{4}')",
            kh.SMaHang, kh.STenHang,kh.SDvt,kh.SGia,kh.SSoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaHangHoa(HangHoa_DTO kh)
        {
            string sTruyVan = string.Format(@"update hanghoa set tenhang = N'{1}', donvitinh = N'{2}' , gia ='{3}', soluong='{4}' where mahanghoa = N'{0}'",
            kh.SMaHang, kh.STenHang,kh.SDvt,kh.SGia,kh.SSoLuong);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaHangHoa(HangHoa_DTO makh)
        {
            string sTruyVan = string.Format(@"delete from hanghoa where mahanghoa = N'{0}'", makh.SMaHang);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static HangHoa_DTO TimHangHoaTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from hanghoa where mahanghoa=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            HangHoa_DTO kh = new HangHoa_DTO();
            kh.SMaHang = dt.Rows[0]["mahanghoa"].ToString();
            kh.STenHang = dt.Rows[0]["tenhang"].ToString();
            kh.SDvt = dt.Rows[0]["donvitinh"].ToString();
            kh.SGia = int.Parse(dt.Rows[0]["gia"].ToString());
            kh.SSoLuong = int.Parse(dt.Rows[0]["soluong"].ToString());

            DataProvider.DongKetNoi(con);
            return kh;
        }
        public static List<HangHoa_DTO> TimHangHoaTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from hanghoa where tenhang like
            N'%{0}%' ", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<DTO.HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO nv = new HangHoa_DTO();
                nv.SMaHang = dt.Rows[i]["mahanghoa"].ToString();
                nv.STenHang = dt.Rows[i]["tenhang"].ToString();
                nv.SDvt = dt.Rows[i]["donvitinh"].ToString();
                nv.SGia = int.Parse(dt.Rows[i]["gia"].ToString());
                nv.SSoLuong = int.Parse(dt.Rows[i]["soluong"].ToString());
                lstHangHoa.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstHangHoa;
        }
    }
}
