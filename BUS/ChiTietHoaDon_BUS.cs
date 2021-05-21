using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietHoaDon_BUS
    {
        public static List<ChiTietHoaDon_DTO> LayDSChiTietHoaDon()
        {
            return ChiTietHoaDon_DAO.LayDSCTHoaDon();
        }
        public static bool ThemChiTietHoaDon(ChiTietHoaDon_DTO kh)
        {
            return ChiTietHoaDon_DAO.ThemChiTietHoaDon(kh);
        }
        public static bool SuaChiTietHoaDon(ChiTietHoaDon_DTO kh)
        {
            return ChiTietHoaDon_DAO.SuaChiTietHoaDon(kh);
        }
        public static bool XoaChiTietHoaDon(ChiTietHoaDon_DTO kh)
        {
            return ChiTietHoaDon_DAO.XoaChiTietHoaDon(kh);
        }

        public static ChiTietHoaDon_DTO TimChiTietHoaDonTheoMa(string mahoadon, string mahang)
        {
            return ChiTietHoaDon_DAO.TimChiTietHoaDonTheoMaHD(mahoadon,mahang);
        }

        public static List<ChiTietHoaDon_DTO> TimChiTietHoaDonTheoMaHoaDon(string ma)
        {
            return ChiTietHoaDon_DAO.TimChiTietHoaDonTheoMaHoaDon(ma);
        }
    }
}
