using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class HoaDon_BUS
    {
        
        public static List<HoaDon_DTO> LayDSHoaDon()
        {
            return HoaDon_DAO.LayDSHoaDon();
        }
        public static bool ThemHoaDon(HoaDon_DTO kh)
        {
            return HoaDon_DAO.ThemHoaDon(kh);
        }
        public static bool SuaHoaDon(HoaDon_DTO kh)
        {
            return HoaDon_DAO.SuaHoaDon(kh);
        }
        public static bool XoaHoaDon(HoaDon_DTO kh)
        {
            return HoaDon_DAO.XoaHoaDon(kh);
        }

        public static HoaDon_DTO TimHoaDonTheoMa(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoMa(ma);
        }

        public static List<HoaDon_DTO> TimHoaDonTheoMaHD(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoMaHD(ma);
        }
        public static List<HoaDon_DTO> TimHoaDonTheoTenTuyen(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoTenTuyen(ma);
        }
        public static List<HoaDon_DTO> TimHoaDonTheoTenKH(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoTenKH(ma);
        }
        public static List<HoaDon_DTO> TimHoaDonTheoTenNV(string ma)
        {
            return HoaDon_DAO.TimHoaDonTheoTenNV(ma);
        }

    }
}
