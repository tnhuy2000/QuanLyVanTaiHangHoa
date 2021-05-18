using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class DauXe_BUS
    {
        //Lấy DS khách hàng
        public static List<DauXe_DTO> LayDSDauXe()
        {
            return DauXe_DAO.LayDSDauXe();
        }
        public static bool ThemDauXe(DauXe_DTO kh)
        {
            return DauXe_DAO.ThemDauXe(kh);
        }
        public static bool SuaDauXe(DauXe_DTO kh)
        {
            return DauXe_DAO.SuaDauXe(kh);
        }
        public static bool XoaDauXe(DauXe_DTO kh)
        {
            return DauXe_DAO.XoaDauXe(kh);
        }

        public static DauXe_DTO TimDauXeTheoMa(string ma)
        {
            return DauXe_DAO.TimDauXeTheoMa(ma);
        }

        public static List<DauXe_DTO> TimDauXeTheoMaKH(string ma)
        {
            return DauXe_DAO.TimDauXeTheoMaDX(ma);
        }

        public static List<DauXe_DTO> TimDauXeTheoTen(string ten)
        {
            return DauXe_DAO.TimDauXeTheoTen(ten);
        }
    }
}
