using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class NguoiDung_BUS
    {
        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Tai_Khoan(string ma)
        {
            return NguoiDung_DAO.Tim_Nguoi_Dung_Theo_Tai_Khoan(ma);
        }
        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Mat_Khau(string ma)
        {
            return NguoiDung_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau(ma);
        }
        public static NguoiDung_DTO Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(string ma, string m)
        {
            return NguoiDung_DAO.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(ma, m);
        }
      
        //Cập nhật thông tin đăng nhập
        public static bool Doi_Mat_Mau(NguoiDung_DTO up)
        {
            return NguoiDung_DAO.Doi_Mat_Khau(up);
        }

        public static string Dang_nhap(NguoiDung_DTO tk)
        {
            return NguoiDung_DAO.Dang_nhap(tk);
        }
        public static bool ThemNguoiDung(NguoiDung_DTO tk)
        {
            return NguoiDung_DAO.ThemNguoiDung(tk);
        }
        public static bool SuaNguoiDung(NguoiDung_DTO kh)
        {
            return NguoiDung_DAO.SuaNguoiDung(kh);
        }
        public static bool XoaNguoiDung(NguoiDung_DTO kh)
        {
            return NguoiDung_DAO.XoaNguoiDung(kh);
        }

        
        
    }
}
