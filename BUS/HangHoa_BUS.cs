using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class HangHoa_BUS
    {
        public static List<HangHoa_DTO> LayDSHangHoa()
        {
            return HangHoa_DAO.LayDSHangHoa();
        }
        public static bool ThemHangHoa(HangHoa_DTO kh)
        {
            return HangHoa_DAO.ThemHangHoa(kh);
        }
        public static bool SuaHangHoa(HangHoa_DTO kh)
        {
            return HangHoa_DAO.SuaHangHoa(kh);
        }
        public static bool XoaHangHoa(HangHoa_DTO kh)
        {
            return HangHoa_DAO.XoaHangHoa(kh);
        }
        public static HangHoa_DTO TimHangHoaTheoMa(string ma)
        {
            return HangHoa_DAO.TimHangHoaTheoMa(ma);
        }

        public static List<HangHoa_DTO> TimHangHoaTheoTen(string ten)
        {
            return HangHoa_DAO.TimHangHoaTheoTen(ten);
        }
    }
}
