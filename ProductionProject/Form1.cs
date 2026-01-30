using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace ProductionProject
{
    public partial class Form1 : Form
    {

        private flightsInfo flights;
        private List<flightsInfo> flightList;
        private flightsMap flightsMap;

        public string json;
        Bitmap map;

        private GMapControl gmap;
        private GMapOverlay aircraftOverlay;
        private GMapOverlay airportOverlay;

        //GMap.NET.WindowsForms.GMapControl gmap;

        private System.Windows.Forms.Timer apiTimer;

        private Image redPlaneIcon;

        public Form1() // constructor
        {
            InitializeComponent();

            apiTimer = new System.Windows.Forms.Timer();
            apiTimer.Interval = 10000; // 10 seconds
            apiTimer.Tick += apiTimer_Tick;
            apiTimer.Start();


            this.Load += Form1_Load;

            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;


            redPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

            flightsMap = new flightsMap(gMapControl1, redPlaneIcon);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                flightList = await apiWAuthorisation.FetchFlightDataAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;

                // map = new Bitmap("leedsMapDemo.png");

                flightsMap.updateFlights(flightList);
                flightsMap.flightPath(flightList);
                flightsMap.drawAirport();
                //drawDetectArea();
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }


        private async void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                flightList = await apiWAuthorisation.FetchFlightDataAsync();
                Debug.WriteLine("API was called");
                //dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }

        }

        private async void apiTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // calls class to get flight data from API
                flightList = await apiWAuthorisation.FetchFlightDataAsync();
                Debug.WriteLine("API was called");

                // resets datagridview
                dataGridView1.DataSource = null;
                //aircraftOverlay.Markers.Clear();
                // updates table with new flight data
                dataGridView1.DataSource = flightList;

                flightsMap.updateFlights(flightList);


            }
            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flightsMap.flightPath(flightList);
            
            Debug.WriteLine("Button Clicked");
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gMapControl_OnPolygonClick(GMapPolygon LdsAirport, MouseEventArgs e)
        {
            MessageBox.Show("You clicked on polygon: " + LdsAirport.Name);
        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void ShowDetectBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowDetectBox.Checked)
            {
                flightsMap.drawDetectArea();
            }
            else { 
               flightsMap.airportOverlay.Polygons.Clear();
                flightsMap.drawAirport();
            }
        }

        
    }
}
