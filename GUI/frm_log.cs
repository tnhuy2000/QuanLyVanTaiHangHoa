﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GUI
{
    public partial class frm_log : Form
    {
        public frm_log()
        {
            InitializeComponent();
        }

        private void frm_log_Load(object sender, EventArgs e)
        {
            StreamReader d = new StreamReader("test.txt");
            txtnhatki.Text = d.ReadToEnd();
            d.Close();
        }
    }
}
