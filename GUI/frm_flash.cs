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
            progressBar.Increment(1);
            lblComplete.Text = progressBar.Value.ToString() + "%";
            if (progressBar.Value == progressBar.Maximum)
            {
                XuLy_timer.Enabled = false;
                //this.Dispose();
                this.Close();
            }
        }

        private void frm_flash_Load(object sender, EventArgs e)
        {
            XuLy_timer.Enabled = true;
            XuLy_timer.Interval =50;
        }
    }
}
