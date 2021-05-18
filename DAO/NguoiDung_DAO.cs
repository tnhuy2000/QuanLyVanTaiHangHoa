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
    public class NguoiDung_DAO
    {
        static SqlConnection con;

        //tìm thông tin người dùng theo mật khẩu
        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            string sTruyVan = string.Format(@"select n.tendangnhap,n.hoten,n.matkhau,n.maquyen,nh.tenquyen from nguoidung n, nhomquyenhan nh where n.matkhau=N'{0}' and nh.maquyen = n.maquyen", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.STenDangNhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.SHoTen = dt.Rows[0]["hoten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.SMaQuyen = dt.Rows[0]["maquyen"].ToString();
            nd.STenQuyen = dt.Rows[0]["tenquyen"].ToString();


            DataProvider.DongKetNoi(con);
            return nd;
        }
        //tìm thông tin người dùng theo tài khoản
        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string tendangnhap)
        {
            string sTruyVan = string.Format(@"select *from nguoidung where tendangnhap=N'{0}'", tendangnhap);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.STenDangNhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.SHoTen = dt.Rows[0]["hoten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.SMaQuyen = dt.Rows[0]["maquyen"].ToString();
           

            DataProvider.DongKetNoi(con);
            return nd;

        }
        

        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where tendangnhap=N'{0}' and matkhau=N'{1}'", ma, m);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.STenDangNhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.SHoTen = dt.Rows[0]["hoten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.SMaQuyen = dt.Rows[0]["maquyen"].ToString();
            


            DataProvider.DongKetNoi(con);
            return nd;
        }
        public static string Dang_nhap(NguoiDung_DTO tk)
        {
            try
            {
                DataTable dt = new DataTable();
                con = DataProvider.MoKetNoi();
                string load = string.Format("SELECT nd.maquyen from nguoidung nd,nhomquyenhan n WHERE nd.maquyen=n.maquyen and tendangnhap=N'{0}' and matkhau=N'{1}'", tk.STenDangNhap, tk.SMatKhau);
                SqlCommand cmd = new SqlCommand(load, con);
                tk.SMaQuyen = cmd.ExecuteScalar().ToString();
                con.Close();
                if (tk.SMaQuyen != "")
                { 
                    return tk.SMaQuyen;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        
        public static bool ThemNguoiDung(NguoiDung_DTO tk)
        {

                string sTruyVan = string.Format(@"INSERT INTO nguoidung VALUES (N'{0}',N'{1}',N'{2}',N'{3}')", 
                    tk.STenDangNhap, tk.SHoTen,tk.SMatKhau, tk.SMaQuyen);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
        }
        public static bool SuaNguoiDung(NguoiDung_DTO tk)
        {
            string sTruyVan = string.Format(@"update nguoidung set hoten=N'{1}', matkhau = N'{2}',maquyen = N'{3}' where tendangnhap = N'{0}'",
           tk.STenDangNhap, tk.SHoTen,tk.SMatKhau,tk.SMaQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNguoiDung(NguoiDung_DTO tendn)
        {
            string sTruyVan = string.Format(@"Delete from nguoidung where tendangnhap = N'{0}'", tendn.STenDangNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //Đổi mật khẩu
        public static bool Doi_Mat_Khau(NguoiDung_DTO dn)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau=N'{0}' where tendangnhap=N'{1}'", dn.SMatKhau, dn.STenDangNhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
