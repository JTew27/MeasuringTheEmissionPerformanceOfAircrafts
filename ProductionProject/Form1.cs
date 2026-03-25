using Newtonsoft.Json;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using CsvHelper.Configuration.Attributes;


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
        private FlightFuelConsumption flightFuelConsumption;
        public string json;
        Bitmap map;

        private GMapControl gmap;
        private GMapOverlay aircraftOverlay;
        private GMapOverlay airportOverlay;

        //GMap.NET.WindowsForms.GMapControl gmap;

        private System.Windows.Forms.Timer apiTimer;
        private System.Windows.Forms.Timer clock;

        public Image redPlaneIcon;
        



        public string userSearch = "EGCC";//defualt parameter to use when the program starts which can be changed with search box and button

        public Form1() // constructor to instantiate form and set up timers and map
        {
            InitializeComponent();

            //instantiate a timer at 10 second intervals to call API and update flight data every 10 seconds using the system timer class
            apiTimer = new System.Windows.Forms.Timer();
            apiTimer.Interval = 10000; // 10 seconds
            apiTimer.Tick += APITimer_Tick;
            apiTimer.Start();

            //instantiates a cloock to display on the interface using the system time
            clock = new System.Windows.Forms.Timer();
            clock.Interval = 1000; // 1 second
            clock.Tick += ClockTick;
            clock.Start();

            flightsMap = new flightsMap(gMapControl1, redPlaneIcon);

            //set up label text to show user what data they are looking at based on the search parameter
            flightInfoLabel.Text = "Live Flight Data for: " + userSearch;
            departureLabel.Text = "Airport Departures (24hrs) for: " + userSearch;
            arrivalLabel.Text = "Aiport Arrivals (24hrs) for: " + userSearch;


            this.Load += Form1_Load;

            //defines the split contatiner and adds the gMap to the left panel of the split container and sets up the map properties and event handlers
            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.Zoom = 2;
            gMapControl1.OnMarkerClick += gMapControl1_OnMarkerClick;
            gMapControl1.OnPolygonClick += gMapControl1_OnPolygonClick;

            //defines the marker icon used to replace a basic marker
            redPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

           

        }

        /// <summary>
        /// When the program runs this will update the user interface with the relevant information from the firs APi endpoint calls 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                
                //call the states endpoint for flight information so that the interface can be updated with relevant information
                flightList = await apiWAuthorisation.GetStatesAsync(client);
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
                flightsMap.updateFlights(flightList);
                flightsMap.drawAirports();
                // map = new Bitmap("leedsMapDemo.png");
                //drawDetectArea();
                
                //calls the departure and arrival endpoint to update the data grid table when the program runs
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

        /// <summary>
        /// handles the event when the refresh button is clicked to refresh the states 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                flightList = await apiWAuthorisation.FetchFlightDataAsync(client);
                Debug.WriteLine("API was called");
                //dataGridView1.DataSource = null;
                dataGridView1.DataSource = flightList;
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }

        }

        /// <summary>
        /// handles the real time aspect with this method being called routinely 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void APITimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // calls class to get flight data from API
                flightList = await apiWAuthorisation.FetchFlightDataAsync(client);
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

        //handles event of drawn polygon is clicked
        private void gMapControl1_OnPolygonClick(GMapPolygon LdsAirport, MouseEventArgs e)
        {
            MessageBox.Show("You clicked on polygon: " + LdsAirport.Name);
        }

        //process of dusplaying further information with when a marker is interacted with the flight path is shown and the fuel consumption metrics are dispalyed
        private async void gMapControl1_OnMarkerClick(GMapMarker aircraft, MouseEventArgs e)
        {
            //catch airport markers
            if (aircraft.ToolTipText.Contains("Airport"))
            {
                return;
            }

            //marker must be an aircraft marker
            else
            {
                var selectedMarker = aircraft as flightMarker;

                foreach (var marker in flightsMap.aircraftOverlay.Markers)
                {
                    var flightMarker = marker as flightMarker;
                    if (flightMarker != null)
                    {
                        flightMarker.PlaneIcon = redPlaneIcon; // reset all markers to default icon
                    }
                }
                // change marker icon to red plane when clicked
                Image selectedPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/redSelectedPlane.png");


                if (selectedMarker != null)
                {
                    selectedMarker.PlaneIcon = selectedPlaneIcon;
                    gMapControl1.Refresh();
                }

                MessageBox.Show("You clicked on marker: " + aircraft.ToolTipText);
                var flight = aircraft.Tag as flightsInfo;
                //call flight fuel consumption class to get fuel consumption for selected flight
                var fuelConsumption = new FlightFuelConsumption(flight);

                string icao = flight.icao24;
                long last_contact = flight.lastContactUnix;
                flightsPath = await apiWAuthorisation.GetFlightPath(client, icao, last_contact);
                flightsMap.points.Clear();
                flightsMap.trackedIcao = flight.icao24;
                flightsMap.flightPath(flightsPath, flight.icao24);
            }
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
                flightsMap.drawAirports();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void ClockTick(object sender, EventArgs e)
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
