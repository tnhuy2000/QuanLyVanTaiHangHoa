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
    public partial class frm_flash : Form
    {
        public frm_flash()
        {
            InitializeComponent();
        }

        private void XuLy_timer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(2);
            lblComplete.Text = progressBar.Value.ToString() + "%";
            this.Opacity -= 0.02;

            if (progressBar.Value >= progressBar.Maximum)
            {
                XuLy_timer.Stop();
                this.Close();
            }
        }

        private void frm_flash_Load(object sender, EventArgs e)
        {
            XuLy_timer.Start();
            XuLy_timer.Enabled = true;
            XuLy_timer.Interval =50;
        }
    }
}
