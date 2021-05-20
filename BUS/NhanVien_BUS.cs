﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhanVien_BUS
    {
        //Lấy DS nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            return NhanVien_DAO.LayDSNhanVien();
        }

        //Lấy DS nhân viên theo họ tên
        public static List<NhanVien_DTO> TimNhanVienTheoHoTen(string hoten)
        {
            return NhanVien_DAO.TimNhanVienTheoHoTen(hoten);
        }

        public static List<NhanVien_DTO> TimNhanVienTheoMaNV(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMaNV(ma);
        }

        //Lấy một nhân viên theo mã
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }

        //Thêm 1 nhân viên
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }

        //Sửa 1 nhân viên
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }

        //Xóa 1 nhân viên
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.XoaNhanVien(nv);
        }
    }
}
