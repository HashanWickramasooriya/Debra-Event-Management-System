using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DebraFrontEnd
{
    public partial class Reguster : Form
    {
        public Reguster()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await RegisterPartnerAsync();
        }

        private async Task RegisterPartnerAsync()
        {
            using (var client = new HttpClient())
            {
                var regRequest = new
                {
                    PartnerName = textBox1.Text,
                    PartnerEmail = textBox2.Text,
                    PartnerPassword = textBox3.Text
                };

                var json = JsonConvert.SerializeObject(regRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:44376");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.PostAsync("/api/Partner/register", content);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        var partner = JsonConvert.DeserializeObject<Partner>(responseBody);

                        PartnerHome partnerHome = new PartnerHome(partner.PartnerId.ToString());
                        partnerHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registration not successful.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }

}
