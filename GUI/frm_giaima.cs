using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace GUI
{
    public partial class frm_giaima : Form
    {
        public frm_giaima()
        {
            InitializeComponent();
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {


            //MaHoaMD5 mahoa = new MaHoaMD5();
            //string strPass = mahoa.Decrypt(txtchuoibimahoa.Text);
            //txtkq_giaima.Text = strPass;

            Encode mahoa1 = new Encode();
            string strPass = mahoa1.Decrypt(txtchuoibimahoa.Text);
            txtkq_giaima.Text = strPass;


        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            //MaHoaMD5 mahoa = new MaHoaMD5();
            //string strPass = mahoa.Encrypt(txtchuoicanmahoa.Text);
            //txtkq_mahoa.Text = strPass;


            Encode mahoa = new Encode();
            string strPass = mahoa.Encrypt(txtchuoicanmahoa.Text);
            txtkq_mahoa.Text = strPass;
        }
    }
}
