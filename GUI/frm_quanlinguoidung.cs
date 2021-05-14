using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_QuanLyNguoiDung : Form
    {
        public frm_QuanLyNguoiDung()
        {
            InitializeComponent();
        }
        private void HienThiDSNguoiDungLenDatagrid()
        {
            List<NguoiDung_DTO> lstNguoiDung = NguoiDung_BUS.LayDSNguoiDung();
            dgvDSNguoiDung.DataSource = lstNguoiDung;

            dgvDSNguoiDung.Columns["Tendangnhap"].HeaderText = "Tên đăng nhập";
            dgvDSNguoiDung.Columns["Matkhau"].HeaderText = "Mật khẩu";
            dgvDSNguoiDung.Columns["Maquyen"].HeaderText = "Mã quyền";

            dgvDSNguoiDung.Columns["Tendangnhap"].Width = 100;
            dgvDSNguoiDung.Columns["Matkhau"].Width = 100;
            dgvDSNguoiDung.Columns["Maquyen"].Width = 100;



        }

        private void frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            // Datagrid người dùng
            HienThiDSNguoiDungLenDatagrid();
            //hiển thị combobox
            cboQuyen.DataSource = NhomQuyen_BUS.Load_DSCV();
            cboQuyen.DisplayMember = "tenquyen";
            cboQuyen.ValueMember = "maquyen";
            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == ""||txtNhapLaiMatKhau.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã khách hàng có độ dài chuỗi hợp lệ hay không
                if (txtTenDangNhap.Text.Length <= 3)
                {
                    MessageBox.Show("Tên đăng nhập tối thiểu 4 ký tự!");
                    return;
                }
                else
                {
                    // Kiểm tra tên đăng nhập có bị trùng không
                    if (NguoiDung_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txtTenDangNhap.Text) != null)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        return;
                    }
                    else
                    {
                        if (txtMatKhau.Text != txtNhapLaiMatKhau.Text)
                        {
                            MessageBox.Show("Xác nhận mật khẩu chưa chính xác !", "Thông báo", MessageBoxButtons.OK);
                            txtMatKhau.Focus();
                        }
                        else
                        {
                            NguoiDung_DTO nd = new NguoiDung_DTO();
                            nd.Tendangnhap = txtTenDangNhap.Text;
                            nd.Matkhau = txtMatKhau.Text;
                            nd.Maquyen = cboQuyen.SelectedValue.ToString();


                            if (NguoiDung_BUS.ThemNguoiDung(nd) == false)
                            {
                                MessageBox.Show("Không thêm được.");
                                return;
                            }
                            HienThiDSNguoiDungLenDatagrid();
                            MessageBox.Show("Đã thêm người dùng.");
                        }    
                    }    
                }    
            } 
        }

        private void dgvDSNguoiDung_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgvDSNguoiDung.SelectedRows[0];
            txtTenDangNhap.Text = r.Cells["Tendangnhap"].Value.ToString();
            txtMatKhau.Text = r.Cells["Matkhau"].Value.ToString();
            txtNhapLaiMatKhau.Text = txtMatKhau.Text;
            cboQuyen.SelectedValue = r.Cells["Maquyen"].Value;
        }
    }
}
