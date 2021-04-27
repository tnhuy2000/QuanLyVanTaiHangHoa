using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class KhachHang_BUS
    {
        //Lấy DS khách hàng
        public static List<KhachHang_DTO> LayDSKhachHang()
        {
            return KhachHang_DAO.LayDSKhachHang();
        }
        public static bool ThemKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.ThemKhachHang(kh);
        }
        public static bool SuaKhachHang(KhachHang_DTO kh)
        {
            return KhachHang_DAO.SuaKhachHang(kh);
        }
        public static bool XoaKhachHang(string kh)
        {
            return KhachHang_DAO.XoaKhachHang(kh);
        }
        public static KhachHang_DTO TimKhachHangTheoMa(string ma)
        {
            return KhachHang_DAO.TimKhachHangTheoMa(ma);
        }
    }
}
