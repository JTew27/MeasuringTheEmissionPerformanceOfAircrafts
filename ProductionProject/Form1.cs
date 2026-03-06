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
        private HttpClient client = new HttpClient();

        private flightsInfo flights;
        private List<flightsInfo> flightList;
        private List<airportDepartures> departureList;
        private List<airportArrivals> arrivalList;
        private List<flightsPath> flightsPath;

        private flightsMap flightsMap;
        private FlightFuelConsumption flightFuelConsumption = new FlightFuelConsumption();

        public string json;
        Bitmap map;

        private GMapControl gmap;
        private GMapOverlay aircraftOverlay;
        private GMapOverlay airportOverlay;

        //GMap.NET.WindowsForms.GMapControl gmap;

        private System.Windows.Forms.Timer apiTimer;
        private System.Windows.Forms.Timer clock;

        public Image redPlaneIcon;
        



        public string userSearch = "EGCC";

        public Form1() // constructor
        {
            InitializeComponent();

            apiTimer = new System.Windows.Forms.Timer();
            apiTimer.Interval = 10000; // 10 seconds
            apiTimer.Tick += apiTimer_Tick;
            apiTimer.Start();

            clock = new System.Windows.Forms.Timer();
            clock.Interval = 1000; // 1 second
            clock.Tick += clockTick;
            clock.Start();

            flightInfoLabel.Text = "Live Flight Data for: " + userSearch;
            departureLabel.Text = "Airport Departures (24hrs) for: " + userSearch;
            arrivalLabel.Text = "Aiport Arrivals (24hrs) for: " + userSearch;


            this.Load += Form1_Load;

            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.OnMarkerClick += gMapControl1_OnMarkerClick;
            gMapControl1.OnPolygonClick += gMapControl1_OnPolygonClick;


            redPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

            flightsMap = new flightsMap(gMapControl1, redPlaneIcon);

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {


                flightList = await apiWAuthorisation.GetStatesAsync(client);
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;

                // map = new Bitmap("leedsMapDemo.png");

                flightsMap.updateFlights(flightList);
                flightsMap.drawAirport();

                //drawDetectArea();

                departureList = await apiWAuthorisation.GetDepartures(client, userSearch);
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = departureList;

                arrivalList = await apiWAuthorisation.GetArrivals(client, userSearch);
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = arrivalList;

            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
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

     
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gMapControl1_OnPolygonClick(GMapPolygon LdsAirport, MouseEventArgs e)
        {
            MessageBox.Show("You clicked on polygon: " + LdsAirport.Name);
        }

        private async void gMapControl1_OnMarkerClick(GMapMarker aircraft, MouseEventArgs e)
        {
            // change marker icon to red plane when clicked
            Image selectedPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/redSelectedPlane.png");
            var marker = aircraft as flightMarker;
            
            if (marker != null) {
                marker.PlaneIcon = selectedPlaneIcon;
                gMapControl1.Refresh(); 
            }

            MessageBox.Show("You clicked on marker: " + aircraft.ToolTipText);
            var flight = aircraft.Tag as flightsInfo;
            //call flight fuel consumption class to get fuel consumption for selected flight
            flightFuelConsumption.CalculateFuelConsumption(aircraft.ToolTipText, flight.velocity, flight.baro_altitude, flight.geo_altitude, flight.vertical_rate, flight.category);
            string icao = flight.icao24;
            long last_contact = flight.lastContactUnix;
            flightsPath = await apiWAuthorisation.GetFlightPath(client, icao, last_contact);
            flightsMap.flightPath(flightsPath);
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
            else
            {
                flightsMap.airportOverlay.Polygons.Clear();
                flightsMap.drawAirport();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void clockTick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            Invalidate();

            String userSearch = entryBox.Text.Trim();
            Debug.WriteLine("Search Button Clicked Parameter:" + userSearch);

            arrivalList = await apiWAuthorisation.GetArrivals(client, userSearch);
            departureList = await apiWAuthorisation.GetDepartures(client, userSearch);

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = arrivalList;
           
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = departureList;

            departureLabel.Text = "Airport Departures (24hrs) for: " + userSearch;
            arrivalLabel.Text = "Aiport Arrivals (24hrs) for: " + userSearch;

        }
    }
}
