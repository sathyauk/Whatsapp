using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp
{
    public partial class FrmWhatsapp : Form
    {
        public FrmWhatsapp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmSendText();
            frm.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendImage();
            frm.ShowDialog();
        }
    }
}
