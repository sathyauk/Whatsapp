using Microsoft.Extensions.Configuration;
using RestSharp;
using Whatsapp.Modal;

namespace Whatsapp
{
    public partial class FrmSendImage : Form
    {
        private readonly IConfiguration _configuration;
        private readonly CustomerContext _context;

        private int pinCode { get; set; } = 0;

        public FrmSendImage(CustomerContext context, IConfiguration configuration)
        {
            InitializeComponent();
            _context = context;
            _configuration= configuration;
        }
        private string GetImage()
        {
            using (Image image = Image.FromFile(openFileDialog1.FileName))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }


        private IList<Customer> GetCustomers(int pinCode = 0)
        {
            var customer = new List<Customer>();
            var c = _context.Customers.Where(x => x.PinCode == pinCode);

            customer = pinCode > 0 ? c.ToList() : _context.Customers.ToList();
            
            return customer;
        }


        private void FrmSendImage_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "PinCode";
            comboBox1.ValueMember = "PinCode";
            comboBox1.DataSource = GetCustomers();
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ComboBox)sender;
            pinCode = (int)item.SelectedValue;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var customers = GetCustomers(pinCode);

            foreach (var customer in customers)
            {
                //var url = "https://api.ultramsg.com/instance61189/messages/image";
                var url = _configuration.GetSection("Whatsapp:ImageUrl").Value;
                
                var client = new RestClient(url);

                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                //request.AddParameter("token", "b0lb60f0ca9xy8c3");
                request.AddParameter("token", _configuration.GetSection("Whatsapp:Token").Value);
                request.AddParameter("to", customer.MobileNumber);
                request.AddParameter("image", GetImage());
                request.AddParameter("caption", "image Caption");
                RestResponse response = client.Execute(request);
                var output = response.Content;
            }
        }
    }
}