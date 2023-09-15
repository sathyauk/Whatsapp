using RestSharp;


namespace Whatsapp
{
    public partial class FrmSendImage : Form
    {
        public FrmSendImage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var customers = GetCustomers();

            foreach(var customer in customers)
            {
                var url = "https://api.ultramsg.com/instance61189/messages/image";
                var client = new RestClient(url);

                var request = new RestRequest(url, Method.Post);
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                request.AddParameter("token", "b0lb60f0ca9xy8c3");
                //request.AddParameter("to", "+919444384710");
                request.AddParameter("to", customer.MobileNumber);
                request.AddParameter("image", GetImage());
                request.AddParameter("caption", "image Caption");
                RestResponse response = client.Execute(request);
                var output = response.Content;
            }

           
        }

        private string GetImage()
        {
            using (Image image = Image.FromFile("C:\\Docs\\test.jpg"))
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


        private IList<Modal.Customer> GetCustomers()
        {
            using (var ctx = new Modal.CustomerContext())
            {
                return ctx.Customers.ToList();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}