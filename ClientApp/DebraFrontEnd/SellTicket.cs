using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DebraFrontEnd
{
    public partial class SellTicket : Form
    {
        public SellTicket()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await AddTicket();
        }

        private async Task AddTicket()
        {
            using (var client = new HttpClient())
            {
                if (!int.TryParse(textBox1.Text, out int ticketId))
                {
                    MessageBox.Show("Please enter a valid Ticket ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textBox2.Text, out int commission))
                {
                    MessageBox.Show("Please enter a valid commission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var sellRequest = new
                {
                    TicketID = ticketId,
                    Commission = commission
                };

                var json = JsonConvert.SerializeObject(sellRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:44376");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.PostAsync("/api/Sale", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Ticket sold successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to sell ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellTicket_Load(object sender, EventArgs e)
        {

        }
    }
}
