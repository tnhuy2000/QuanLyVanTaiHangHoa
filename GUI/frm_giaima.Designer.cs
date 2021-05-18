
namespace GUI
{
    partial class frm_giaima
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtchuoibimahoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.txtchuoicanmahoa = new System.Windows.Forms.TextBox();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkq_giaima = new System.Windows.Forms.TextBox();
            this.txtkq_mahoa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chuỗi cần giải mã:";
            // 
            // txtchuoibimahoa
            // 
            this.txtchuoibimahoa.Location = new System.Drawing.Point(175, 133);
            this.txtchuoibimahoa.Name = "txtchuoibimahoa";
            this.txtchuoibimahoa.Size = new System.Drawing.Size(224, 20);
            this.txtchuoibimahoa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kết quả:";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(450, 147);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(87, 33);
            this.btnGiaiMa.TabIndex = 4;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // txtchuoicanmahoa
            // 
            this.txtchuoicanmahoa.Location = new System.Drawing.Point(175, 32);
            this.txtchuoicanmahoa.Name = "txtchuoicanmahoa";
            this.txtchuoicanmahoa.Size = new System.Drawing.Size(224, 20);
            this.txtchuoicanmahoa.TabIndex = 2;
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(450, 49);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(87, 33);
            this.btnMaHoa.TabIndex = 4;
            this.btnMaHoa.Text = "Mã hoá";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập chuỗi cần mã hoá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả:";
            // 
            // txtkq_giaima
            // 
            this.txtkq_giaima.Location = new System.Drawing.Point(175, 173);
            this.txtkq_giaima.Name = "txtkq_giaima";
            this.txtkq_giaima.Size = new System.Drawing.Size(224, 20);
            this.txtkq_giaima.TabIndex = 2;
            // 
            // txtkq_mahoa
            // 
            this.txtkq_mahoa.Location = new System.Drawing.Point(175, 62);
            this.txtkq_mahoa.Name = "txtkq_mahoa";
            this.txtkq_mahoa.Size = new System.Drawing.Size(224, 20);
            this.txtkq_mahoa.TabIndex = 2;
            // 
            // frm_giaima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 273);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkq_mahoa);
            this.Controls.Add(this.txtchuoicanmahoa);
            this.Controls.Add(this.txtkq_giaima);
            this.Controls.Add(this.txtchuoibimahoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frm_giaima";
            this.Text = "frm_giaima";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtchuoibimahoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.TextBox txtchuoicanmahoa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtkq_giaima;
        private System.Windows.Forms.TextBox txtkq_mahoa;
    }
}