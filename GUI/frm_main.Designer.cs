
namespace GUI
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuStrip_QuanLy = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TaiXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.vậnTảiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHienThiNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDatetime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiThànhMàuĐỏToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiThànhMàuVàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel6 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel6_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.mnuStrip_QuanLy.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.dockPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip_QuanLy
            // 
            this.mnuStrip_QuanLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnu_DanhMuc,
            this.mnu_NghiepVu,
            this.mnu_BaoCao,
            this.mnu_HuongDan});
            this.mnuStrip_QuanLy.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip_QuanLy.Name = "mnuStrip_QuanLy";
            this.mnuStrip_QuanLy.Size = new System.Drawing.Size(843, 24);
            this.mnuStrip_QuanLy.TabIndex = 0;
            this.mnuStrip_QuanLy.Text = "mnuStrip_QuanLy";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_DangKy,
            this.mnu_DoiMatKhau,
            this.mnu_DangXuat,
            this.mnu_Thoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnu_DangKy
            // 
            this.mnu_DangKy.Name = "mnu_DangKy";
            this.mnu_DangKy.Size = new System.Drawing.Size(145, 22);
            this.mnu_DangKy.Text = "Đăng ký";
            this.mnu_DangKy.Click += new System.EventHandler(this.mnu_DangKy_Click);
            // 
            // mnu_DoiMatKhau
            // 
            this.mnu_DoiMatKhau.Name = "mnu_DoiMatKhau";
            this.mnu_DoiMatKhau.Size = new System.Drawing.Size(145, 22);
            this.mnu_DoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // mnu_DangXuat
            // 
            this.mnu_DangXuat.Name = "mnu_DangXuat";
            this.mnu_DangXuat.Size = new System.Drawing.Size(145, 22);
            this.mnu_DangXuat.Text = "Đăng xuất";
            this.mnu_DangXuat.Click += new System.EventHandler(this.mnu_DangXuat_Click);
            // 
            // mnu_Thoat
            // 
            this.mnu_Thoat.Name = "mnu_Thoat";
            this.mnu_Thoat.Size = new System.Drawing.Size(145, 22);
            this.mnu_Thoat.Text = "Thoát";
            this.mnu_Thoat.Click += new System.EventHandler(this.mnu_Thoat_Click);
            // 
            // mnu_DanhMuc
            // 
            this.mnu_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_KhachHang,
            this.mnu_TaiXe});
            this.mnu_DanhMuc.Name = "mnu_DanhMuc";
            this.mnu_DanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnu_DanhMuc.Text = "Danh mục";
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.Size = new System.Drawing.Size(137, 22);
            this.mnu_KhachHang.Text = "Khách hàng";
            this.mnu_KhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnu_TaiXe
            // 
            this.mnu_TaiXe.Name = "mnu_TaiXe";
            this.mnu_TaiXe.Size = new System.Drawing.Size(137, 22);
            this.mnu_TaiXe.Text = "Tài xế";
            // 
            // mnu_NghiepVu
            // 
            this.mnu_NghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vậnTảiToolStripMenuItem});
            this.mnu_NghiepVu.Name = "mnu_NghiepVu";
            this.mnu_NghiepVu.Size = new System.Drawing.Size(74, 20);
            this.mnu_NghiepVu.Text = "Nghiệp vụ";
            // 
            // vậnTảiToolStripMenuItem
            // 
            this.vậnTảiToolStripMenuItem.Name = "vậnTảiToolStripMenuItem";
            this.vậnTảiToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.vậnTảiToolStripMenuItem.Text = "Vận tải";
            // 
            // mnu_BaoCao
            // 
            this.mnu_BaoCao.Name = "mnu_BaoCao";
            this.mnu_BaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnu_BaoCao.Text = "Báo cáo";
            // 
            // mnu_HuongDan
            // 
            this.mnu_HuongDan.Name = "mnu_HuongDan";
            this.mnu_HuongDan.Size = new System.Drawing.Size(79, 20);
            this.mnu_HuongDan.Text = "Hướng dẫn";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHienThiNguoiDung,
            this.toolStripStatusLabel1,
            this.tssDatetime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(843, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHienThiNguoiDung
            // 
            this.lblHienThiNguoiDung.Name = "lblHienThiNguoiDung";
            this.lblHienThiNguoiDung.Size = new System.Drawing.Size(80, 17);
            this.lblHienThiNguoiDung.Text = "Nhóm quyền:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(675, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "CHƯƠNG TRÌNH QUẢN LÝ VẬN TẢI HÀNG HOÁ";
            // 
            // tssDatetime
            // 
            this.tssDatetime.AutoToolTip = true;
            this.tssDatetime.Image = global::GUI.Properties.Resources.clock2;
            this.tssDatetime.Name = "tssDatetime";
            this.tssDatetime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tssDatetime.Size = new System.Drawing.Size(73, 17);
            this.tssDatetime.Text = "DateTime";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiThànhMàuĐỏToolStripMenuItem,
            this.đổiThànhMàuVàngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(183, 48);
            // 
            // đổiThànhMàuĐỏToolStripMenuItem
            // 
            this.đổiThànhMàuĐỏToolStripMenuItem.Name = "đổiThànhMàuĐỏToolStripMenuItem";
            this.đổiThànhMàuĐỏToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.đổiThànhMàuĐỏToolStripMenuItem.Text = "Đổi thành màu đỏ";
            // 
            // đổiThànhMàuVàngToolStripMenuItem
            // 
            this.đổiThànhMàuVàngToolStripMenuItem.Name = "đổiThànhMàuVàngToolStripMenuItem";
            this.đổiThànhMàuVàngToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.đổiThànhMàuVàngToolStripMenuItem.Text = "Đổi thành màu vàng";
            // 
            // dockPanel6
            // 
            this.dockPanel6.Controls.Add(this.dockPanel6_Container);
            this.dockPanel6.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel6.DockedAsTabbedDocument = true;
            this.dockPanel6.ID = new System.Guid("9211c2cf-005b-4d7f-9b9a-28a522c19d81");
            this.dockPanel6.Location = new System.Drawing.Point(0, 0);
            this.dockPanel6.Name = "dockPanel6";
            this.dockPanel6.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel6.SavedIndex = 2;
            this.dockPanel6.SavedMdiDocument = true;
            this.dockPanel6.Size = new System.Drawing.Size(200, 200);
            this.dockPanel6.Text = "dockPanel6";
            // 
            // dockPanel6_Container
            // 
            this.dockPanel6_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel6_Container.Name = "dockPanel6_Container";
            this.dockPanel6_Container.Size = new System.Drawing.Size(192, 172);
            this.dockPanel6_Container.TabIndex = 0;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(843, 518);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuStrip_QuanLy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_main_KeyUp);
            this.mnuStrip_QuanLy.ResumeLayout(false);
            this.mnuStrip_QuanLy.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.dockPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip_QuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnu_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnu_DangKy;
        private System.Windows.Forms.ToolStripMenuItem mnu_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnu_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnu_NghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnu_BaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnu_HuongDan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssDatetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đổiThànhMàuĐỏToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiThànhMàuVàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel6;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel6_Container;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblHienThiNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnu_TaiXe;
        private System.Windows.Forms.ToolStripMenuItem vậnTảiToolStripMenuItem;
    }
}