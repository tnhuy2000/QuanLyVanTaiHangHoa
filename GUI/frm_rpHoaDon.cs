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
    public partial class frm_rpHoaDon : Form
    {
        public frm_rpHoaDon()
        {
            InitializeComponent();
        }

        private void frm_rpHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVTHHDataSet2.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.QLVTHHDataSet2.DataTable1);
            // TODO: This line of code loads data into the 'QLVTHHDataSet.nhanvien' table. You can move, or remove it, as needed.
            //this.nhanvienTableAdapter.Fill(this.QLVTHHDataSet.nhanvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
