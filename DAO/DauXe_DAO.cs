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
    public class DauXe_DAO
    {
        static SqlConnection con;
        // Lấy danh sách tất cả khách hàng
        public static List<DauXe_DTO> LayDSDauXe()
        {
            string sTruyVan = "select d.*,tx.hoten from dauxe d, taixe tx where d.mataixe=tx.mataixe";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DauXe_DTO> lstDauXe = new List<DTO.DauXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DauXe_DTO kh = new DauXe_DTO();
                kh.SMaDX = dt.Rows[i]["madauxe"].ToString();
                kh.SBienSo = dt.Rows[i]["bienso"].ToString();
                kh.STenXe = dt.Rows[i]["tenxe"].ToString();
                kh.SMauSon = dt.Rows[i]["mauson"].ToString();
                kh.SDungTich = dt.Rows[i]["dungtich"].ToString();
                kh.DtNamSanXuat = DateTime.Parse(dt.Rows[i]["namsx"].ToString());
                kh.SMaTX = dt.Rows[i]["mataixe"].ToString();
                kh.SHoTen = dt.Rows[i]["hoten"].ToString();
                lstDauXe.Add(kh);
            }
            DataProvider.DongKetNoi(con);
            return lstDauXe;
        }
        public static bool ThemDauXe(DauXe_DTO kh)
        {
            string sTruyVan = string.Format(@"insert into dauxe values('{0}','{1}',N'{2}',N'{3}','{4}','{5}','{6}')",
                kh.SMaDX, kh.SBienSo, kh.STenXe, kh.SMauSon, kh.SDungTich, kh.DtNamSanXuat.ToString("yyyy/MM/dd"), kh.SMaTX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaDauXe(DauXe_DTO kh)
        {
            string sTruyVan = string.Format(@"update dauxe set bienso = '{1}', tenxe = N'{2}', mauson = '{3}',dungtich = '{4}',namsx = '{5}',mataixe = '{6}' where madauxe = '{0}'",
            kh.SMaDX, kh.SBienSo, kh.STenXe, kh.SMauSon, kh.SDungTich, kh.DtNamSanXuat.ToString("yyyy/MM/dd"), kh.SMaTX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaDauXe(DauXe_DTO dx)
        {
            string sTruyVan = string.Format(@"delete from dauxe where madauxe='{0}'", dx.SMaDX);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static DauXe_DTO TimDauXeTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from dauxe where madauxe=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            DauXe_DTO kh = new DauXe_DTO();
            kh.SMaDX = dt.Rows[0]["madauxe"].ToString();
            kh.SBienSo = dt.Rows[0]["bienso"].ToString();
            kh.STenXe = dt.Rows[0]["tenxe"].ToString();
            kh.SMauSon = dt.Rows[0]["mauson"].ToString();
            kh.SDungTich = dt.Rows[0]["dungtich"].ToString();
            kh.DtNamSanXuat = DateTime.Parse(dt.Rows[0]["namsx"].ToString());
            kh.SMaTX = dt.Rows[0]["mataixe"].ToString();
            

            DataProvider.DongKetNoi(con);
            return kh;
        }
        public static List<DauXe_DTO> TimDauXeTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from dauxe where hoten like
            N'%{0}%' ", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DauXe_DTO> lstNhanVien = new List<DTO.DauXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DauXe_DTO dx = new DauXe_DTO();
                dx.SMaDX = dt.Rows[i]["madauxe"].ToString();
                dx.SBienSo = dt.Rows[i]["bienso"].ToString();
                dx.STenXe = dt.Rows[i]["tenxe"].ToString();
                dx.SMauSon = dt.Rows[i]["mauson"].ToString();
                dx.SDungTich = dt.Rows[i]["dungtich"].ToString();
                dx.DtNamSanXuat = DateTime.Parse(dt.Rows[i]["namsx"].ToString());
                dx.SMaTX = dt.Rows[i]["mataixe"].ToString();
                

                lstNhanVien.Add(dx);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static List<DauXe_DTO> TimDauXeTheoMaDX(string ma)
        {
            string sTruyVan = string.Format(@"select * from dauxe where madauxe like N'%{0}%' ", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<DauXe_DTO> lstNhanVien = new List<DTO.DauXe_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DauXe_DTO dx = new DauXe_DTO();
                dx.SMaDX = dt.Rows[i]["madauxe"].ToString();
                dx.SBienSo = dt.Rows[i]["bienso"].ToString();
                dx.STenXe = dt.Rows[i]["tenxe"].ToString();
                dx.SMauSon = dt.Rows[i]["mauson"].ToString();
                dx.SDungTich =dt.Rows[i]["dungtich"].ToString();
                dx.DtNamSanXuat = DateTime.Parse(dt.Rows[0]["namsx"].ToString());
                dx.SMaTX = dt.Rows[i]["mataixe"].ToString();

                lstNhanVien.Add(dx);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
