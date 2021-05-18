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
    public partial class frm_dangky : Form
    {
        public static string ten;
        
        public frm_dangky(string tendangnhap)
        {
            InitializeComponent();
            ten = tendangnhap;
            
        }

        private void frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            
            

            txtMatKhau.UseSystemPasswordChar = true;
            txtNhapLaiMatKhau.UseSystemPasswordChar = true;



            //NguoiDung_DTO nv = new NguoiDung_DTO();
            
            //cboQuyen.DataSource = nv.STenQuyen;
            //combobox chucvu

            List<NhomQuyen_DTO> LstChucVu = NhomQuyen_BUS.LayQuyen();
            cboQuyen.DataSource = LstChucVu;
            //NhomQuyen_DTO d1 = new NhomQuyen_DTO();
            cboQuyen.DisplayMember = "STenQuyen";

            //LstChucVu.Insert(0, d1);
            cboQuyen.ValueMember = "SMaQuyen";



           
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == ""||txtNhapLaiMatKhau.Text=="" ||txtHoTen.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            else
            {
                // Kiểm tra mã  có độ dài chuỗi hợp lệ hay không
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
                            Encode mahoa = new Encode();
                            NguoiDung_DTO nd = new NguoiDung_DTO();
                            nd.STenDangNhap = txtTenDangNhap.Text;
                            nd.SHoTen = txtHoTen.Text;
                            nd.SMatKhau = mahoa.Encrypt(txtMatKhau.Text);
                            //nd.STenQuyen = cboQuyen.SelectedItem.ToString();
                            nd.SMaQuyen = cboQuyen.SelectedValue.ToString();


                            if (NguoiDung_BUS.ThemNguoiDung(nd) == false)
                            {
                                MessageBox.Show("Không đăng ký được.");
                                return;
                            }
                            
                            MessageBox.Show("Đã đăng ký.");
                            WriteLog.Write(ten, "Đã đăng ký người dùng có tên: " + txtHoTen.Text);
                        }    
                    }    
                }    
            } 
        }

        

        
        

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn đóng form!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                this.Close();
                WriteLog.Write(ten, "Đã đóng form Quản Lý Người Dùng");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
