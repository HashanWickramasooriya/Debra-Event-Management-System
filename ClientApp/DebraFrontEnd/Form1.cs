using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DebraFrontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Type = "admin";
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Type = "partner";
            login.Show();
        }
    }
}
