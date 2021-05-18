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
namespace GUI
{
    public partial class frm_main : Form
    {
        private string ten;
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
            //frm_dangnhap dn = new frm_dangnhap();
            if (this.ten == "admin")
            {
                lblHienThiNguoiDung.Text = "Bạn là Administrator";
            }
            else if(this.ten=="KT")
            {
                lblHienThiNguoiDung.Text = "Bạn là Nhân viên kế toán";
            }
            else
            {
                lblHienThiNguoiDung.Text = "Bạn là Nhân viên kinh doanh";
            }    
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

        }
        public void Admin()
        {
            this.mnuHeThong.Enabled = true;
            this.mnu_DanhMuc.Enabled = true;
            this.mnu_NghiepVu.Enabled = true;
            this.mnu_HuongDan.Enabled = true;

        }
        public void KeToan()
        {
            this.mnuHeThong.Enabled = true;
            //this.mnu_DanhMuc.Enabled = true;
            this.mnu_KhachHang.Enabled = true;
            this.mnu_TaiXe.Enabled = false;
            //this.mnu_NghiepVu.Enabled = true;
            this.mnu_HuongDan.Enabled = true;

        }
        public void KinhDoanh()
        {
            this.mnuHeThong.Enabled = true;
            //this.mnu_DanhMuc.Enabled = true;
            this.mnu_KhachHang.Enabled = false;
            this.mnu_TaiXe.Enabled = true;
            //this.mnu_NghiepVu.Enabled = true;
            this.mnu_HuongDan.Enabled = true;

        }

        private void mnu_DangKy_Click(object sender, EventArgs e)
        {
            frm_dangky f = new frm_dangky(ten);
            WriteLog.Write(ten, "Mở form Đăng ký");
            ViewChildForm(f);
        }

        private void mnu_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_dangnhap dn = new frm_dangnhap();
            WriteLog.Write(ten, "Đăng xuất");
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
            ViewChildForm(f);
        }
        private void mnuDauXe_Click(object sender, EventArgs e)
        {
            frm_dauxe f = new frm_dauxe(ten);
            WriteLog.Write(ten, "Mở form Đàu Xe");
            ViewChildForm(f);
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frm_hanghoa f = new frm_hanghoa(ten);
            WriteLog.Write(ten, "Mở form Hàng Hoá");
            ViewChildForm(f);
        }

        private void mnuStrip_QuanLy_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
