using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_khachhang : Form
    {
        public frm_khachhang()
        {
            InitializeComponent();
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            // Datagrid nhân viên
            HienThiDSKhachHangLenDatagrid();
        }

        private void HienThiDSKhachHangLenDatagrid()
        {
            List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.LayDSKhachHang();
            dgvDSKhachHang.DataSource = lstKhachHang;
            
            dgvDSKhachHang.Columns["SMaKH"].HeaderText = "Mã số";
            dgvDSKhachHang.Columns["SHoTen"].HeaderText = "Họ tên";
            dgvDSKhachHang.Columns["SDiaChi"].HeaderText = "Địa chỉ";
            dgvDSKhachHang.Columns["SDienThoai"].HeaderText = "Điện thoại";
            dgvDSKhachHang.Columns["SCmnd"].HeaderText = "CMND";
      
            dgvDSKhachHang.Columns["SMaKH"].Width = 80;
            dgvDSKhachHang.Columns["SHoTen"].Width = 150;
            dgvDSKhachHang.Columns["SDiaChi"].Width = 200;
            dgvDSKhachHang.Columns["SDienThoai"].Width = 120;
            dgvDSKhachHang.Columns["SCmnd"].Width = 100;
            
        }

        private void mi_Them_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
            if (txtMaKH.Text.Length > 5)
            {
                MessageBox.Show("Mã khách hàng tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã khách hàng có bị trùng không
            if (KhachHang_BUS.TimKhachHangTheoMa(txtMaKH.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.SMaKH = txtMaKH.Text;
            kh.SHoTen = txtHoTen.Text;
            kh.SDiaChi = txtDiaChi.Text;

            kh.SDienThoai =txtDienThoai.Text;
            kh.SCmnd = txtCmnd.Text;
            if (KhachHang_BUS.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            HienThiDSKhachHangLenDatagrid();
            MessageBox.Show("Đã thêm khách hàng.");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
