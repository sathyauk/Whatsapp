using Microsoft.Extensions.Configuration;
using Whatsapp.Modal;

namespace Whatsapp
{
    public partial class FrmWhatsapp : Form
    {
        private readonly CustomerContext _context;
        private readonly IConfiguration _configuration;

        public FrmWhatsapp(CustomerContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendText(_context, _configuration);
            frm.ShowDialog();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var frm = new FrmSendImage(_context, _configuration);
            frm.ShowDialog();
        }
    }
}
