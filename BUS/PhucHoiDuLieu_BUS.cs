using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhucHoiDuLieu_BUS
    {
        public static bool Restore(string sDuongDan)
        {
            return PhuHoiDuLieu_DAO.PhucHoi(sDuongDan);
        }
    }
}
