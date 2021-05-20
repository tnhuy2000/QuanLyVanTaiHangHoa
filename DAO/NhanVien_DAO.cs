using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class NhanVien_DAO
    {

        static SqlConnection con;

        // Lấy danh sách tất cả nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien()
        {
            string sTruyVan = "select nv.*,q.tenquyen from nhanvien nv, nhomquyenhan q where nv.maquyen=q.maquyen";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoTen = dt.Rows[i]["tennv"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.SSdt = dt.Rows[i]["sdt"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.SMaQuyen = dt.Rows[i]["maquyen"].ToString();
                nv.STenQuyen = dt.Rows[i]["tenquyen"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        // Tìm ds nhân viên theo họ và tên, trả về null nếu không thấy
        public static List<NhanVien_DTO> TimNhanVienTheoHoTen(string hoten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like N'%{0}%'", hoten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoTen = dt.Rows[i]["tennv"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.SSdt = dt.Rows[i]["sdt"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.SMaQuyen = dt.Rows[i]["maquyen"].ToString();
                //nv.STenQuyen = dt.Rows[i]["tenquyen"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.SHoTen = dt.Rows[0]["tennv"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SPhai = dt.Rows[0]["gioitinh"].ToString();
            nv.SSdt = dt.Rows[0]["sdt"].ToString();
            nv.SDiaChi = dt.Rows[0]["diachi"].ToString();
            nv.SMaQuyen = dt.Rows[0]["maquyen"].ToString();
            //nv.STenQuyen = dt.Rows[0]["tenquyen"].ToString();

            DataProvider.DongKetNoi(con);
            return nv;
        }

        public static List<NhanVien_DTO> TimNhanVienTheoMaNV(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv like '%{0}%'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoTen = dt.Rows[i]["tennv"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SPhai = dt.Rows[i]["gioitinh"].ToString();
                nv.SSdt = dt.Rows[i]["sdt"].ToString();
                nv.SDiaChi = dt.Rows[i]["diachi"].ToString();
                nv.SMaQuyen = dt.Rows[i]["maquyen"].ToString();
                //nv.STenQuyen = dt.Rows[i]["tenquyen"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }

        // Thêm nhân viên
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N'{0}',N'{1}','{2}',N'{3}','{4}',N'{5}',N'{6}')",
                nv.SMaNV, nv.SHoTen, nv.DtNgaySinh.ToString("yyyy/MM/dd"), nv.SPhai,nv.SSdt,nv.SDiaChi, nv.SMaQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Sửa nhân viên
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"update nhanvien set tennv=N'{1}',ngaysinh='{2}',gioitinh=N'{3}',sdt='{4}',diachi=N'{5}',maquyen=N'{6}' where manv=N'{0}'", 
                nv.SMaNV, nv.SHoTen, nv.DtNgaySinh.ToString("yyyy/MM/dd"), nv.SPhai,nv.SSdt,nv.SDiaChi, nv.SMaQuyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        // Xóa nhân viên
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"delete from nhanvien where manv=N'{0}'", nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
