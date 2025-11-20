using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ProductionProject
{
    public partial class Form1 : Form
    {
        private API api;

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
                string json = await api.GetStatesAsync();
                Debug.WriteLine("API was called");
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }


    }
}
