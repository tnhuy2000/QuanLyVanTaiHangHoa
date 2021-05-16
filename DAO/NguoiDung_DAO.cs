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
            string sTruyVan = string.Format(@"select tendangnhap,matkhau,n.maquyen,nh.tenquyen from nguoidung n, nhomquyenhan nh where n.matkhau=N'{0}' and nh.maquyen = n.maquyen", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;

            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.Tendangnhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
            nd.Maquyen = dt.Rows[0]["maquyen"].ToString();
            nd.Tenquyen = dt.Rows[0]["tenquyen"].ToString();


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
            nd.Tendangnhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
            nd.Maquyen = dt.Rows[0]["maquyen"].ToString();

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
            nd.Tendangnhap = dt.Rows[0]["tendangnhap"].ToString();
            nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
            nd.Maquyen = dt.Rows[0]["maquyen"].ToString();


            DataProvider.DongKetNoi(con);
            return nd;
        }
        public static string Dang_nhap(NguoiDung_DTO tk)
        {
            try
            {
                DataTable dt = new DataTable();
                con = DataProvider.MoKetNoi();
                string load = string.Format("SELECT nd.maquyen from nguoidung nd,nhomquyenhan n WHERE nd.maquyen=n.maquyen and tendangnhap=N'{0}' and matkhau=N'{1}'", tk.Tendangnhap, tk.Matkhau);
                SqlCommand cmd = new SqlCommand(load, con);
                tk.Maquyen = cmd.ExecuteScalar().ToString();
                con.Close();
                if (tk.Maquyen != "")
                {
                    //string select = string.Format("SELECT * FROM db_taikhoan,db_chucvu WHERE username='{0}' and pass='{1}'and db_taikhoan.ma_cv = '{2}' and trang_thai='{3}';UPDATE db_taikhoan SET trang_thai = true WHERE username='{0}'", tk.username, tk.password, tk.ma_cv, tk.trang_thai);
                    //DataProvider.Execute(cnn, select);
                    //cnn.Close();
                    return tk.Maquyen;
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
        // Lấy danh sách tất cả nguoidung
        public static List<NguoiDung_DTO> LayDSNguoiDung()
        {
            string sTruyVan = "select nd.tendangnhap,nd.matkhau,nd.maquyen,n.tenquyen from nguoidung nd, nhomquyenhan n where nd.maquyen=n.maquyen";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> lstNguoiDung = new List<DTO.NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.Tendangnhap = dt.Rows[i]["tendangnhap"].ToString();
                nd.Matkhau = dt.Rows[i]["matkhau"].ToString();
                nd.Maquyen= dt.Rows[i]["maquyen"].ToString();

                lstNguoiDung.Add(nd);
            }
            DataProvider.DongKetNoi(con);
            return lstNguoiDung;
        }
        public static bool ThemNguoiDung(NguoiDung_DTO tk)
        {

                string sTruyVan = string.Format("INSERT INTO nguoidung(tendangnhap,matkhau,maquyen) VALUES ('{0}','{1}','{2}');", tk.Tendangnhap, tk.Matkhau, tk.Maquyen);
                con = DataProvider.MoKetNoi();
                bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
                DataProvider.DongKetNoi(con);
                return kq;
        }
        public static bool SuaNguoiDung(NguoiDung_DTO tk)
        {
            string sTruyVan = string.Format(@"update nguoidung set tendangnhap = N'{1}', matkhau = N'{2}',maquyen = N'{3}'",
           tk.Tendangnhap,tk.Matkhau,tk.Maquyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNguoiDung(string tendn)
        {
            string sTruyVan = string.Format(@"Delete from nguoidung where tendangnhap = N'{0}'", tendn);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //Đổi mật khẩu
        public static bool Doi_Mat_Khau(NguoiDung_DTO dn)
        {
            string sTruyVan = string.Format(@"update nguoidung set matkhau=N'{0}' where tendangnhap=N'{1}'", dn.Matkhau, dn.Tendangnhap);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
