using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frm_main : Form
    {
        public static string ten;
        
        public frm_main(string tendangnhap)
        {
            InitializeComponent();

            ten = tendangnhap;

        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Lay ngày giờ hiện tại hệ thống
            DateTime t = DateTime.Now;
            string day = t.Day.ToString();
            string month = t.Month.ToString();
            string year = t.Year.ToString();
            string hour = t.Hour.ToString();
            string min = "";
            int minu = t.Minute;
            if(minu<10)
            {
                min = "0" + t.Minute.ToString();
            }
            else
            {
                min = t.Minute.ToString();
            }    

            string sec = t.Second.ToString();
            tssDatetime.Text = "Ngày "+day + ", tháng " + month + " , năm " + year + " - " + hour + ":" + min + ":" + sec;
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frm_khachhang f = new frm_khachhang(ten);
            WriteLog.Write(ten, "Mở form Khách Hàng");

            ViewChildForm(f);
        }
        
       
        private void frm_main_Load(object sender, EventArgs e)
        {
            
            this.KeyPreview = true;
            IsMdiContainer = true;
            
                
            
        }
       
        public void ViewChildForm(Form _form)
        {
            //check before open
            if (!IsFormActived(_form))
            {
                
                _form.MdiParent = this;
                _form.Show();
            }
        }
        private bool IsFormActived(Form form)
        {
            bool IsOpenend = false;
            if (MdiChildren.Count()>0)
            {
                foreach(var item in MdiChildren)
                {
                    if(form.Name==item.Name)
                    {
                        //Active this form
                        xtraTabbedMdiManager1.Pages[item].MdiChild.Activate();
                        IsOpenend = true;
                    }
                }
            }
            return IsOpenend;
        }
        public void MacDinh()
        {
            this.mnuHeThong.Enabled = true;
            this.mnu_DangKy.Enabled = true;
            
            this.mnu_DanhMuc.Enabled = false;
            this.mnu_NghiepVu.Enabled = false;
            this.mnu_HuongDan.Enabled = false;
            this.mnu_BaoCao.Enabled = false;
            this.nhậtKýHệThốngToolStripMenuItem.Enabled = false;
        }
        public void Admin()
        {
            lblHienThiNguoiDung.Text = "Người dùng: Quản trị viên";
            this.mnuHeThong.Enabled = true;
            this.mnu_DanhMuc.Enabled = true;
            this.mnu_NghiepVu.Enabled = true;
            this.mnu_HuongDan.Enabled = true;
            this.mnu_BaoCao.Enabled = true;
            this.mnutool_saoluu_phuchoi.Visible = true;
            this.nhậtKýHệThốngToolStripMenuItem.Visible = true;
            this.mnu_DangKy.Visible = true;
        }
        public void KeToan()
        {
            lblHienThiNguoiDung.Text = "Người dùng: Nhân viên kế toán";
            //ko co quyen
            this.mnu_TaiXe.Enabled = false;
            this.mnu_KhachHang.Enabled = false;
            this.mnu_TaiXe.Enabled = false;
            this.mnu_DangKy.Visible = false;
            this.mnutool_saoluu_phuchoi.Visible = false;
            this.nhậtKýHệThốngToolStripMenuItem.Visible = false;
            //dc quyen su dung
            this.mnu_LapHoaDonVT.Enabled = true;
            this.mnu_NhanVien.Enabled = true;
            this.mnu_HuongDan.Enabled = true;
            this.mnu_DangXuat.Enabled = true;
            this.mnu_Thoat.Enabled = true;
            this.mnu_DoiMatKhau.Enabled = true;
            

        }
        public void KinhDoanh()
        {
            lblHienThiNguoiDung.Text = "Người dùng: Nhân viên kinh doanh";
            this.mnu_KhachHang.Enabled = true;
            this.mnu_TaiXe.Enabled = true;
            this.mnu_tuyenduong.Enabled = true;
            this.mnuHangHoa.Enabled = true;
            this.mnu_DangXuat.Enabled = true;
            this.mnu_Thoat.Enabled = true;
            this.mnu_HuongDan.Enabled = true;

            //ko co quyen
            this.mnu_LapHoaDonVT.Enabled = false;
            this.mnu_NhanVien.Enabled = false;
            this.mnu_DangKy.Visible = false;
            this.mnutool_saoluu_phuchoi.Visible = false;
            this.nhậtKýHệThốngToolStripMenuItem.Visible = false;

        }

        private void mnu_DangKy_Click(object sender, EventArgs e)
        {
            frm_dangky f = new frm_dangky(ten);
            WriteLog.Write(ten, "Mở form Đăng ký");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã mở form Đăng ký";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }

        private void mnu_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_dangnhap dn = new frm_dangnhap();
            WriteLog.Write(ten, "Đăng xuất");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Đăng xuất";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            dn.Show();   
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult tr;
            tr = MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
            {
                Application.Exit();
                WriteLog.Write(ten, "Thoát chương trình");
            }    
                
        }

        private void frm_main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Escape))
                {
                    mnu_Thoat_Click(null, null);
                }
            }
        }

        private void mnu_TaiXe_Click(object sender, EventArgs e)
        {
            frm_taixe f = new frm_taixe(ten);
            WriteLog.Write(ten, "Mở form Tài Xế");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Mở form Tài Xế";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }
        private void mnuDauXe_Click(object sender, EventArgs e)
        {
            frm_dauxe f = new frm_dauxe(ten);
            WriteLog.Write(ten, "Mở form Đàu Xe");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Mở form Đầu Xe";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frm_hanghoa f = new frm_hanghoa(ten);
            WriteLog.Write(ten, "Mở form Hàng Hoá");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Mở form Hàng Hoá";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }

        private void mnuStrip_QuanLy_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            frm_nhanvien f = new frm_nhanvien(ten);
            WriteLog.Write(ten, "Mở form Nhân Viên");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Mở form Nhân Viên";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }

        private void mnu_tuyenduong_Click(object sender, EventArgs e)
        {
            frm_tuyenduong f = new frm_tuyenduong(ten);
            WriteLog.Write(ten, "Mở form QL Tuyến Đường");
            //ghi file log
            StreamWriter writer = new StreamWriter("test.txt", true);
            string chuoi = " ";
            string getdate = DateTime.Now.ToString();
            chuoi = "\n****    Vào lúc: " + getdate + " ---Tài khoản: " + ten + " --->Đã Mở form QL Tuyến Đường";
            writer.WriteLine(chuoi);
            writer.Close();
            ////
            ViewChildForm(f);
        }

        private void nhậtKýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_log f = new frm_log();
            WriteLog.Write(ten, "Mở form log");
            
            ViewChildForm(f);
        }

        private void mnu_DangNhap_Click(object sender, EventArgs e)
        {
            
            frm_dangnhap f = new frm_dangnhap();
            f.Show();
            
        }

        private void mnu_SaoLuu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (SaoLuu_BUS.SaoLuuDuLieu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void mnu_PhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
           phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (PhucHoiDuLieu_BUS.Restore(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
