using RestSharp;
using System;

namespace Whatsapp
{
    public partial class FrmSendText : Form
    {
        public FrmSendText()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var customers = GetCustomers();

            foreach (var customer in customers)
            {
                var url = "https://api.ultramsg.com/instance61189/messages/image";
                var client = new RestClient(url);

                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("token", "b0lb60f0ca9xy8c3");
                //request.AddParameter("to", "+919444384710");
                request.AddParameter("to", customer.MobileNumber);
                request.AddParameter("body", rtfMessage.Text);
                request.AddParameter("caption", "image Caption");
                RestResponse response = client.Execute(request);
                var output = response.Content;
            }

        }

        private IList<Modal.Customer> GetCustomers()
        {
            using (var ctx = new Modal.CustomerContext())
            {
                return ctx.Customers.ToList();
            }
        }


    }
}
