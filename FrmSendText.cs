using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using Whatsapp.Modal;

namespace Whatsapp
{
    public partial class FrmSendText : Form
    {
        private readonly CustomerContext _context;
        private readonly IConfiguration _configuration;
        private int PinCode { get; set; } = 0;

        public FrmSendText(CustomerContext context, IConfiguration configuration)
        {
            InitializeComponent();
            _context = context;
            _configuration = configuration;
        }

        private IList<Customer> GetCustomers(int pinCode = 0)
        {
            var customer = new List<Customer>();
            var c = _context.Customers.Where(x => x.PinCode == pinCode);

            customer = pinCode > 0 ? c.ToList() : _context.Customers.ToList();

            return customer;
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            var customers = GetCustomers();

            foreach (var customer in customers)
            {
                //var url = "https://api.ultramsg.com/instance61189/messages/image";
                var url = _configuration.GetSection("Whatsapp:ChatUrl").Value;

                var client = new RestClient(url);

                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("token", _configuration.GetSection("Whatsapp:Token").Value);
                //request.AddParameter("to", "+919444384710");
                request.AddParameter("to", customer.MobileNumber);
                request.AddParameter("body", rtfMessage.Text);
                request.AddParameter("caption", "image Caption");
                RestResponse response = client.Execute(request);
                var output = response.Content;
            }
        }

        private void cmbPinCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ComboBox)sender;
            PinCode = (int)item.SelectedValue;
        }

        private void FrmSendText_Load(object sender, EventArgs e)
        {
            cmbPinCode.DisplayMember = "PinCode";
            cmbPinCode.ValueMember = "PinCode";
            cmbPinCode.DataSource = GetCustomers();
            cmbPinCode.SelectedIndex = 1;
        }
    }
}
