
namespace GUI
{
    partial class frm_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_khachhang));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mi_Them = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Huy = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtCmnd = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.mi_Them,
            this.mi_Xoa,
            this.mi_Sua,
            this.mi_Luu,
            this.mi_Huy,
            this.mi_Thoat});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbonControl1.Size = new System.Drawing.Size(736, 140);
            // 
            // mi_Them
            // 
            this.mi_Them.Caption = "Thêm";
            this.mi_Them.Id = 1;
            this.mi_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Them.ImageOptions.Image")));
            this.mi_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Them.ImageOptions.LargeImage")));
            this.mi_Them.LargeWidth = 55;
            this.mi_Them.Name = "mi_Them";
            this.mi_Them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mi_Them_ItemClick);
            // 
            // mi_Xoa
            // 
            this.mi_Xoa.Caption = "Xoá";
            this.mi_Xoa.Id = 2;
            this.mi_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Xoa.ImageOptions.Image")));
            this.mi_Xoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Xoa.ImageOptions.LargeImage")));
            this.mi_Xoa.LargeWidth = 55;
            this.mi_Xoa.Name = "mi_Xoa";
            // 
            // mi_Sua
            // 
            this.mi_Sua.Caption = "Sửa";
            this.mi_Sua.Id = 3;
            this.mi_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Sua.ImageOptions.Image")));
            this.mi_Sua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Sua.ImageOptions.LargeImage")));
            this.mi_Sua.LargeWidth = 55;
            this.mi_Sua.Name = "mi_Sua";
            // 
            // mi_Luu
            // 
            this.mi_Luu.Caption = "Lưu";
            this.mi_Luu.Id = 4;
            this.mi_Luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Luu.ImageOptions.Image")));
            this.mi_Luu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Luu.ImageOptions.LargeImage")));
            this.mi_Luu.LargeWidth = 55;
            this.mi_Luu.Name = "mi_Luu";
            // 
            // mi_Huy
            // 
            this.mi_Huy.Caption = "Huỷ";
            this.mi_Huy.Id = 5;
            this.mi_Huy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Huy.ImageOptions.Image")));
            this.mi_Huy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Huy.ImageOptions.LargeImage")));
            this.mi_Huy.LargeWidth = 55;
            this.mi_Huy.Name = "mi_Huy";
            // 
            // mi_Thoat
            // 
            this.mi_Thoat.Caption = "Thoát";
            this.mi_Thoat.Id = 6;
            this.mi_Thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Thoat.ImageOptions.Image")));
            this.mi_Thoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Thoat.ImageOptions.LargeImage")));
            this.mi_Thoat.LargeWidth = 55;
            this.mi_Thoat.Name = "mi_Thoat";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Khách Hàng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Them);
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Xoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Sua);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mi_Luu);
            this.ribbonPageGroup2.ItemLinks.Add(this.mi_Huy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mi_Thoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtCmnd);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(101, 95);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(565, 24);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(99, 57);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 24);
            this.txtHoTen.TabIndex = 5;
            // 
            // txtCmnd
            // 
            this.txtCmnd.Location = new System.Drawing.Point(466, 57);
            this.txtCmnd.Name = "txtCmnd";
            this.txtCmnd.Size = new System.Drawing.Size(200, 24);
            this.txtCmnd.TabIndex = 5;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(466, 21);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(200, 24);
            this.txtDienThoai.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(99, 21);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(200, 24);
            this.txtMaKH.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH:";
            // 
            // dgvDSKhachHang
            // 
            this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhachHang.Location = new System.Drawing.Point(0, 289);
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachHang.Size = new System.Drawing.Size(724, 218);
            this.dgvDSKhachHang.TabIndex = 5;
            // 
            // frm_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 519);
            this.Controls.Add(this.dgvDSKhachHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_khachhang";
            this.Text = "frm_khachhang";
            this.Load += new System.EventHandler(this.frm_khachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem mi_Them;
        private DevExpress.XtraBars.BarButtonItem mi_Xoa;
        private DevExpress.XtraBars.BarButtonItem mi_Sua;
        private DevExpress.XtraBars.BarButtonItem mi_Luu;
        private DevExpress.XtraBars.BarButtonItem mi_Huy;
        private DevExpress.XtraBars.BarButtonItem mi_Thoat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDSKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCmnd;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}