using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ProductionProject
{
    public partial class Form1 : Form
    {
        private API api;
        private flightsInfo flights;
        private List<flightsInfo> flightList;
        public string json;
        public Form1()
        {
            InitializeComponent();
            api = new API();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                flightList = await api.GetStatesAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                flightList = await api.GetStatesAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }
    }
}
