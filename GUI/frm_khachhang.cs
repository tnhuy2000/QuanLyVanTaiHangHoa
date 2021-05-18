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
        public static string ten;
        public frm_khachhang(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            // Datagrid nhân viên
            HienThiDSKhachHangLenDatagrid();
            cboTimKiem.Items.Add("Theo mã khách hàng");
            cboTimKiem.Items.Add("Theo tên khách hàng");
            this.cboTimKiem.SelectedItem = "Theo tên khách hàng";
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

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtMaKH.Text.Length > 6)
                {
                    MessageBox.Show("Mã khách hàng tối đa 6 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra mã khách hàng có bị trùng không
                    if (KhachHang_BUS.TimKhachHangTheoMa(txtMaKH.Text) != null)
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!");
                        return;
                    }
                    else
                    {
                        KhachHang_DTO kh = new KhachHang_DTO();
                        kh.SMaKH = txtMaKH.Text;
                        kh.SHoTen = txtHoTen.Text;
                        kh.SDiaChi = txtDiaChi.Text;

                        kh.SDienThoai = txtDienThoai.Text;
                        kh.SCmnd = txtCmnd.Text;
                        if (KhachHang_BUS.ThemKhachHang(kh) == false)
                        {
                            MessageBox.Show("Không thêm được.");
                            return;
                        }
                        HienThiDSKhachHangLenDatagrid();
                        MessageBox.Show("Đã thêm khách hàng.");
                        WriteLog.Write(ten, "Đã thêm khách hàng có mã số: "+txtMaKH.Text);
                    }    
                }    
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKH.Text == "" || KhachHang_BUS.TimKhachHangTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn xoá khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if(tr==DialogResult.OK)
                {
                    KhachHang_DTO kh = new KhachHang_DTO();
                    kh.SMaKH = txtMaKH.Text;
                    kh.SHoTen = txtHoTen.Text;
                    kh.SDienThoai = txtDienThoai.Text;
                    kh.SDiaChi = txtDiaChi.Text;
                    kh.SCmnd = txtCmnd.Text;

                    if (KhachHang_BUS.XoaKhachHang(kh) == true)
                    {
                        HienThiDSKhachHangLenDatagrid();
                        MessageBox.Show("Đã xóa khách hàng.");
                        WriteLog.Write(ten, "Đã xoá khách hàng có mã số: " + txtMaKH.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không xóa được.");
                    }
                }    
            }
        }

        private void dgvDSKhachHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSKhachHang.SelectedRows[0];
            txtMaKH.Text = r.Cells["SMaKH"].Value.ToString();
            txtHoTen.Text = r.Cells["SHoTen"].Value.ToString();
            txtDiaChi.Text = r.Cells["SDiaChi"].Value.ToString();
            txtDienThoai.Text = r.Cells["SDienThoai"].Value.ToString();
            txtCmnd.Text = r.Cells["SCmnd"].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaKH.Text == "" || KhachHang_BUS.TimKhachHangTheoMa(txtMaKH.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã khách hàng!");
                return;
            }
            else
            {
                DialogResult tr;
                tr = MessageBox.Show("Bạn có muốn sửa khách hàng này không?", "Thông báo", MessageBoxButtons.OKCancel
                    , MessageBoxIcon.Question);
                if (tr == DialogResult.OK)
                {
                    KhachHang_DTO kh = new KhachHang_DTO();
                    kh.SMaKH = txtMaKH.Text;
                    kh.SHoTen = txtHoTen.Text;
                    kh.SDiaChi = txtDiaChi.Text;
                    kh.SDienThoai = txtDienThoai.Text;
                    kh.SCmnd = txtCmnd.Text;

                    if (KhachHang_BUS.SuaKhachHang(kh) == true)
                    {
                        HienThiDSKhachHangLenDatagrid();
                        MessageBox.Show("Đã cập nhật thông tin khách hàng.");
                        WriteLog.Write(ten, "Đã cập nhật khách hàng có mã số: " + txtMaKH.Text);
                    }
                    else
                    {
                        MessageBox.Show("Không cập nhật được.");
                    }
                }
            }
        }
        
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboTimKiem.SelectedItem.ToString()=="Theo mã khách hàng")
            {
                string ma = txtTimKiem.Text;

                List<KhachHang_DTO> lstnv1 = KhachHang_BUS.TimKhachHangTheoMaKH(ma);
                if (lstnv1 == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSKhachHang.DataSource = lstnv1;
            }
            else if(cboTimKiem.SelectedItem.ToString() == "Theo tên khách hàng")
            {
                string ten = txtTimKiem.Text;

                List<KhachHang_DTO> lstnv = KhachHang_BUS.TimKhachHangTheoTen(ten);
                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dgvDSKhachHang.DataSource = lstnv;
            }    
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đóng form!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                this.Close();
                WriteLog.Write(ten, "Đã đóng form Khách Hàng");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDSKhachHangLenDatagrid();
        }
    }
}
