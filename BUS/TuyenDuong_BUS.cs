using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class TuyenDuong_BUS
    {
        //Lấy DS khách hàng
        public static List<TuyenDuong_DTO> LayDSTuyenDuong()
        {
            return TuyenDuong_DAO.LayDSTuyenDuong();
        }
        public static bool ThemTuyenDuong(TuyenDuong_DTO kh)
        {
            return TuyenDuong_DAO.ThemTuyenDuong(kh);
        }
        public static bool SuaTuyenDuong(TuyenDuong_DTO kh)
        {
            return TuyenDuong_DAO.SuaTuyenDuong(kh);
        }
        public static bool XoaTuyenDuong(TuyenDuong_DTO kh)
        {
            return TuyenDuong_DAO.XoaTuyenDuong(kh);
        }

        public static TuyenDuong_DTO TimTuyenDuongTheoMa(string ma)
        {
            return TuyenDuong_DAO.TimTuyenDuongTheoMa(ma);
        }

        public static List<TuyenDuong_DTO> TimTuyenDuongTheoMaTD(string ma)
        {
            return TuyenDuong_DAO.TimTuyenTheoMaTD(ma);
        }

        public static List<TuyenDuong_DTO> TimTuyenDuongTheoTen(string ten)
        {
            return TuyenDuong_DAO.TimTuyenDuongTheoTen(ten);
        }
    }
}
