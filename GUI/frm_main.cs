using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }

        NguoiDung_Controller ndctrl = new NguoiDung_Controller();
        int kq;
        private void frm_main_Load(object sender, EventArgs e)
        {
            /*
            //frm_dangnhap dn = new frm_dangnhap();
            if(dn.ShowDialog()==DialogResult.OK)
            {
                kq=ndctrl.XuLyDangNhap(dn.txtUsername.Text, dn.txtPassword.Text);
                if (kq == 0)
                {
                    TatChucNang();
                    MessageBox.Show("Đăng nhập thất bại, xin kiểm tra lại username và password ");
                }
                else PhanQuyen(kq);
            }
            */
        }
        //hàm tắt các chức năng của chương trình
        //Enable các menu=false
        public void TatChucNang()
        {
            mi_KhachHang.Enabled = false;
            mi_HangHoa.Enabled = false;
            
        }
        public void PhanQuyen(int quyen)
        {
            switch (quyen)
            {
                case 1://quyền admin
                    {
                        mi_KhachHang.Enabled = true;
                        mi_HangHoa.Enabled = true;
                        
                        break;
                    }
                case 2://quyền user
                    {
                        mi_KhachHang.Enabled = false;
                        mi_HangHoa.Enabled = false;
                        
                        break;
                    }
                default:
                    {
                        TatChucNang();
                        break;
                    }
            }
                
        }

        private void mi_Thoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult tr;
            tr=MessageBox.Show("Bạn có muốn thoát chương trình hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tr == DialogResult.OK)
                Application.Exit();
        }

        private void mi_KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.Show();
        }
    }
}
