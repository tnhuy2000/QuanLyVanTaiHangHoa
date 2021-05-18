using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }
        
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // kiem tra du lieu co bi bo trong
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;

            }
            Encode mahoa = new Encode();
            string password_mahoa = mahoa.Encrypt(txtMatKhau.Text);
            

            // kiem tra người dùng 
            if (NguoiDung_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txtTenDangNhap.Text) == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return;
            }

            // kiem tra mật khẩu 
            if (NguoiDung_BUS.Tim_Nguoi_Dung_Theo_Mat_Khau_Kiem_Tra(txtTenDangNhap.Text, password_mahoa) == null)
            {
                MessageBox.Show("Mật khẩu không đúng!");
                return;
            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.STenDangNhap = txtTenDangNhap.Text;
            nd.SMatKhau = password_mahoa;

            if (NguoiDung_BUS.Tim_Nguoi_Dung_Theo_Tai_Khoan(txtTenDangNhap.Text) == null)
            {
                MessageBox.Show("Đăng nhập không thành công");

                return;

            }
            else
            {
                if (NguoiDung_BUS.Dang_nhap(nd) != "")
                {
                    string quyenhan = NguoiDung_BUS.Dang_nhap(nd);
                    switch (quyenhan)
                    {
                        case "admin":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công với quyền admin");
                            WriteLog.Write(txtTenDangNhap.Text, "Đăng nhập thành công");
                            frm_main f1 = new frm_main(txtTenDangNhap.Text);
                            f1.Admin();
                            f1.Show();
                            WriteLog.Write(txtTenDangNhap.Text, "Mở form frm_main");
                            break;
                        case "KT":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!");
                            frm_main f2 = new frm_main(txtTenDangNhap.Text);
                            WriteLog.Write(txtTenDangNhap.Text, "Đăng nhập");
                            f2.KeToan();
                            f2.Show();
                            WriteLog.Write(txtTenDangNhap.Text, "Mở form frm_main");
                            break;
                        case "KD":
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công!");
                            frm_main f3 = new frm_main(txtTenDangNhap.Text);
                            WriteLog.Write(txtTenDangNhap.Text, "Đăng nhập");
                            f3.KinhDoanh();
                            f3.Show();
                            WriteLog.Write(txtTenDangNhap.Text, "Mở form frm_main");
                            break;
                        default:
                            MessageBox.Show("Lỗi!", "Thông báo", MessageBoxButtons.OK);
                            WriteLog.Write(txtTenDangNhap.Text, "Đăng nhập không thành công ");
                            break;
                    }
                }
            }

        }
       
        private void ckHienMK_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ckHienMK.Checked == false)
            {
                txtMatKhau.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hiện mật khẩu";
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }    
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            ckHienMK.Checked = false;
            txtMatKhau.UseSystemPasswordChar = true;
        }

        private void frm_dangnhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    btnDangNhap_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    btnThoat_Click(null, null);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                Application.Exit();
                WriteLog.Write(txtTenDangNhap.Text, "Thoát chương trình");
            }    
                

        }
    }
}
