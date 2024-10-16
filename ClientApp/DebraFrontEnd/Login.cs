using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DebraFrontEnd
{
    public partial class Login : Form
    {
        public string Type { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (Type == "admin")
            {
                if (textBox1.Text == "admin@gmail.com" && textBox2.Text == "admin")
                {
                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                }
                else
                {
                    MessageBox.Show("Please check your email and password");
                }
            }
            else if (Type == "partner")
            {
                await PartnerLoginAsync(textBox1.Text, textBox2.Text);
            }
        }

        private async Task PartnerLoginAsync(string email, string password)
        {
            using (var client = new HttpClient())
            {
                var loginRequest = new
                {
                    LoginEmail = email,
                    LoginPassword = password
                };

                var json = JsonConvert.SerializeObject(loginRequest);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:44376");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.PostAsync("/api/Partner/login", data);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        var partner = JsonConvert.DeserializeObject<Partner>(responseBody);

                        PartnerHome partnerHome = new PartnerHome(partner.PartnerId.ToString());
                        partnerHome.Show();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Couldn't find a partner account for this email.");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Please check your password.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reguster register = new Reguster();
            register.Show();
        }
    }

    public class Partner
    {
        public int PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string PartnerEmail { get; set; }
        public string PartnerPassword { get; set; }
    }
}
