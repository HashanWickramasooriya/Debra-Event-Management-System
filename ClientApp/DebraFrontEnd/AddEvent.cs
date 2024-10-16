using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DebraFrontEnd
{
    public partial class AddEvent : Form
    {
        public string PartnerID { get; set; }

        public AddEvent(string partnerID)
        {
            InitializeComponent();
            PartnerID = partnerID;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            await AddEventAsync();
        }

        private async Task AddEventAsync()
        {
            using (var client = new HttpClient())
            {
                var newEvent = new
                {
                    EventName = textBox1.Text,
                    EventDate = dateTimePicker1.Value,
                    EventLocation = textBox3.Text,
                    PartnerId = int.Parse(PartnerID)
                };

                var json = JsonConvert.SerializeObject(newEvent);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                client.BaseAddress = new Uri("https://localhost:44376");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    HttpResponseMessage response = await client.PostAsync("/api/Event", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Event added successfully!");
                        this.Close(); // Close the form after successful addition
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
