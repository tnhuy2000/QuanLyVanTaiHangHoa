using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class SaoLuu_BUS
    {
        public static bool SaoLuuDuLieu(string sDuongDan)
        {
            return SaoLuu_DAO.SaoLuuDuLieu(sDuongDan);

        }
    }
}
