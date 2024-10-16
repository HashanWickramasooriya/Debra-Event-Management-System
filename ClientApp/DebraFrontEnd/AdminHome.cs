using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DebraFrontEnd
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await GetEarningsAsync();
        }

        private async Task GetEarningsAsync()
        {
            using (var client = new HttpClient())
            {
                string eventId = textBox1.Text;

                client.BaseAddress = new Uri("https://localhost:44376");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.GetAsync($"/api/Sale/event/{eventId}/earnings");

                    if (response.IsSuccessStatusCode)
                    {
                        var responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Total earnings for event {eventId}: {responseBody}");
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.ReasonPhrase}");
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
