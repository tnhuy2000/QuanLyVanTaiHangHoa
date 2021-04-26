
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
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mi_Them = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Sua = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mi_Luu = new DevExpress.XtraBars.BarButtonItem();
            this.mi_Huy = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mi_Thoat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1});
            this.ribbonControl1.Size = new System.Drawing.Size(791, 139);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Them);
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Xoa);
            this.ribbonPageGroup1.ItemLinks.Add(this.mi_Sua);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // mi_Them
            // 
            this.mi_Them.Caption = "Thêm";
            this.mi_Them.Id = 1;
            this.mi_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("mi_Them.ImageOptions.Image")));
            this.mi_Them.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("mi_Them.ImageOptions.LargeImage")));
            this.mi_Them.LargeWidth = 55;
            this.mi_Them.Name = "mi_Them";
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
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mi_Luu);
            this.ribbonPageGroup2.ItemLinks.Add(this.mi_Huy);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
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
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mi_Thoat);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
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
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 136);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 169);
            this.dataGridView1.TabIndex = 5;
            // 
            // frm_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 519);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_khachhang";
            this.Text = "frm_khachhang";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}