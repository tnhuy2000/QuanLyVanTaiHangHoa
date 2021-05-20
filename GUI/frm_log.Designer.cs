
namespace GUI
{
    partial class frm_log
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
            this.txtnhatki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnhatki
            // 
            this.txtnhatki.Location = new System.Drawing.Point(2, 2);
            this.txtnhatki.Multiline = true;
            this.txtnhatki.Name = "txtnhatki";
            this.txtnhatki.Size = new System.Drawing.Size(591, 496);
            this.txtnhatki.TabIndex = 0;
            // 
            // frm_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 504);
            this.Controls.Add(this.txtnhatki);
            this.Name = "frm_log";
            this.Text = "frm_log";
            this.Load += new System.EventHandler(this.frm_log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnhatki;
    }
}