using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiXe_BUS
    {
        public static List<TaiXe_DTO> LayDSTaiXe()
        {
            return TaiXe_DAO.LayDSTaiXe();
        }
        public static bool ThemTaiXe(TaiXe_DTO kh)
        {
            return TaiXe_DAO.ThemTaiXe(kh);
        }
        public static bool SuaTaiXe(TaiXe_DTO kh)
        {
            return TaiXe_DAO.SuaTaiXe(kh);
        }
        public static bool XoaTaiXe(TaiXe_DTO kh)
        {
            return TaiXe_DAO.XoaTaiXe(kh);
        }
        public static TaiXe_DTO TimTaiXeTheoMa(string ma)
        {
            return TaiXe_DAO.TimTaiXeTheoMa(ma);
        }

        public static List<TaiXe_DTO> TimTaiXeTheoTen(string ten)
        {
            return TaiXe_DAO.TimTaiXeTheoTen(ten);
        }
    }
}
