using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Whatsapp.Modal;

namespace Whatsapp
{
    public partial class FrmWhatsapp : Form
    {
        private readonly CustomerContext _context;
        public FrmWhatsapp(CustomerContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendText(_context);
            frm.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendImage(_context);
            frm.ShowDialog();
        }
    }
}
