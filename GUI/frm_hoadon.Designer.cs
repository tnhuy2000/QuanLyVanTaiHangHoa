
namespace GUI
{
    partial class frm_hoadon
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
            this.dgvDSHoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtngaygiao = new System.Windows.Forms.DateTimePicker();
            this.dtngaylap = new System.Windows.Forms.DateTimePicker();
            this.cbotenkhachhang = new System.Windows.Forms.ComboBox();
            this.cbonhanvienlap = new System.Windows.Forms.ComboBox();
            this.cbotentuyenduong = new System.Windows.Forms.ComboBox();
            this.txttongtrigia = new System.Windows.Forms.TextBox();
            this.txtmahoadon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCTHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSHoaDon
            // 
            this.dgvDSHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHoaDon.Location = new System.Drawing.Point(12, 299);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(851, 190);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.Click += new System.EventHandler(this.dgvDSHoaDon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaygiao);
            this.groupBox1.Controls.Add(this.dtngaylap);
            this.groupBox1.Controls.Add(this.cbotenkhachhang);
            this.groupBox1.Controls.Add(this.cbonhanvienlap);
            this.groupBox1.Controls.Add(this.cbotentuyenduong);
            this.groupBox1.Controls.Add(this.txttongtrigia);
            this.groupBox1.Controls.Add(this.txtmahoadon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn:";
            // 
            // dtngaygiao
            // 
            this.dtngaygiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaygiao.Location = new System.Drawing.Point(553, 73);
            this.dtngaygiao.Name = "dtngaygiao";
            this.dtngaygiao.Size = new System.Drawing.Size(174, 21);
            this.dtngaygiao.TabIndex = 3;
            // 
            // dtngaylap
            // 
            this.dtngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaylap.Location = new System.Drawing.Point(553, 38);
            this.dtngaylap.Name = "dtngaylap";
            this.dtngaylap.Size = new System.Drawing.Size(174, 21);
            this.dtngaylap.TabIndex = 3;
            // 
            // cbotenkhachhang
            // 
            this.cbotenkhachhang.FormattingEnabled = true;
            this.cbotenkhachhang.Location = new System.Drawing.Point(151, 92);
            this.cbotenkhachhang.Name = "cbotenkhachhang";
            this.cbotenkhachhang.Size = new System.Drawing.Size(210, 23);
            this.cbotenkhachhang.TabIndex = 2;
            // 
            // cbonhanvienlap
            // 
            this.cbonhanvienlap.FormattingEnabled = true;
            this.cbonhanvienlap.Location = new System.Drawing.Point(151, 127);
            this.cbonhanvienlap.Name = "cbonhanvienlap";
            this.cbonhanvienlap.Size = new System.Drawing.Size(210, 23);
            this.cbonhanvienlap.TabIndex = 2;
            // 
            // cbotentuyenduong
            // 
            this.cbotentuyenduong.FormattingEnabled = true;
            this.cbotentuyenduong.Location = new System.Drawing.Point(151, 58);
            this.cbotentuyenduong.Name = "cbotentuyenduong";
            this.cbotentuyenduong.Size = new System.Drawing.Size(210, 23);
            this.cbotentuyenduong.TabIndex = 2;
            // 
            // txttongtrigia
            // 
            this.txttongtrigia.Location = new System.Drawing.Point(553, 112);
            this.txttongtrigia.Name = "txttongtrigia";
            this.txttongtrigia.Size = new System.Drawing.Size(174, 21);
            this.txttongtrigia.TabIndex = 1;
            // 
            // txtmahoadon
            // 
            this.txtmahoadon.Location = new System.Drawing.Point(151, 24);
            this.txtmahoadon.Name = "txtmahoadon";
            this.txtmahoadon.Size = new System.Drawing.Size(115, 21);
            this.txtmahoadon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "NV lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên KH:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng trị giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày giao:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tuyến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(295, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(546, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(465, 196);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(381, 196);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.Location = new System.Drawing.Point(12, 196);
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(145, 31);
            this.btnCTHD.TabIndex = 36;
            this.btnCTHD.Text = "Thêm chi tiết hoá đơn";
            this.btnCTHD.UseVisualStyleBackColor = true;
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 501);
            this.Controls.Add(this.btnCTHD);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSHoaDon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_hoadon";
            this.Text = "Hoá đơn";
            this.Load += new System.EventHandler(this.frm_hoadon1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtngaygiao;
        private System.Windows.Forms.DateTimePicker dtngaylap;
        private System.Windows.Forms.ComboBox cbotenkhachhang;
        private System.Windows.Forms.ComboBox cbonhanvienlap;
        private System.Windows.Forms.ComboBox cbotentuyenduong;
        private System.Windows.Forms.TextBox txttongtrigia;
        private System.Windows.Forms.TextBox txtmahoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCTHD;
    }
}