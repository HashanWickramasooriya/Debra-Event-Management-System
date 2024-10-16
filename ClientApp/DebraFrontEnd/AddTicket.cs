using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DebraFrontEnd
{
    public partial class AddTicket : Form
    {
        public AddTicket()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string ticketType = textBox1.Text;
            string ticketPriceText = textBox2.Text;
            string eventIdText = textBox3.Text;

            if (string.IsNullOrEmpty(ticketType) || string.IsNullOrEmpty(ticketPriceText) || string.IsNullOrEmpty(eventIdText))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(ticketPriceText, out decimal ticketPrice))
            {
                MessageBox.Show("Please enter a valid ticket price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(eventIdText, out int eventId))
            {
                MessageBox.Show("Please enter a valid event ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var ticketRequest = new
            {
                TicketType = ticketType,
                TicketPrice = ticketPrice,
                EventId = eventId
            };

            string json = JsonConvert.SerializeObject(ticketRequest);

            using (var client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync("https://localhost:44376/api/Ticket", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Ticket added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add ticket. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
