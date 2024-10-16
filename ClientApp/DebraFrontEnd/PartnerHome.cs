using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace DebraFrontEnd
{
    public partial class PartnerHome : Form
    {
        public string PartnerID { get; set; }

        public PartnerHome(string partnerId)
        {
            InitializeComponent();
            PartnerID = partnerId;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            List<EventEarnings> earnings = await FetchEarningsAsync();

            if (earnings != null)
            {
                string message = FormatEarningsMessage(earnings);
                MessageBox.Show(message, "Earnings by Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to retrieve earnings data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<List<EventEarnings>> FetchEarningsAsync()
        {
            List<EventEarnings> earnings = new List<EventEarnings>();

            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"https://localhost:44376/api/Sale/partner/{PartnerID}");

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        earnings = ParseEarnings(json);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return earnings;
        }

        private List<EventEarnings> ParseEarnings(string json)
        {
            List<EventEarnings> earnings = new List<EventEarnings>();

            try
            {
                JArray array = JArray.Parse(json);

                foreach (JToken token in array)
                {
                    EventEarnings eventEarnings = new EventEarnings
                    {
                        EventId = (int)token["eventId"],
                        EventName = (string)token["eventName"],
                        TotalEarnings = (decimal)token["totalEarnings"],
                        Sales = new List<Sale>()
                    };

                    foreach (JToken saleToken in token["sales"])
                    {
                        Sale sale = new Sale
                        {
                            SaleId = (int)saleToken["saleId"],
                            TicketId = (int)saleToken["ticketId"],
                            TicketPrice = (decimal)saleToken["ticketPrice"],
                            SaleDate = (DateTime)saleToken["saleDate"],
                            Commission = (decimal)saleToken["commission"]
                        };

                        eventEarnings.Sales.Add(sale);
                    }

                    earnings.Add(eventEarnings);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing JSON: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return earnings;
        }

        private string FormatEarningsMessage(List<EventEarnings> earnings)
        {
            if (earnings == null || earnings.Count == 0)
            {
                return "No earnings data available.";
            }

            string message = "Earnings by Event:\n\n";

            foreach (var eventEarnings in earnings)
            {
                message += $"Event ID: {eventEarnings.EventId}\n";
                message += $"Event Name: {eventEarnings.EventName}\n";
                message += $"Total Earnings: {eventEarnings.TotalEarnings}\n\n";
            }

            return message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEvent addEvent = new AddEvent(PartnerID);
            addEvent.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddTicket addTicket = new AddTicket();
            addTicket.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SellTicket sellTicket = new SellTicket();
            sellTicket.Show();
        }
    }

    public class EventEarnings
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public decimal TotalEarnings { get; set; }
        public List<Sale> Sales { get; set; }
    }

    public class Sale
    {
        public int SaleId { get; set; }
        public int TicketId { get; set; }
        public decimal TicketPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Commission { get; set; }
    }
}
