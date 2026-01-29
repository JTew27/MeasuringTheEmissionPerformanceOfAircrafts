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

            gMapControl1.MapProvider = GMapProviders.GoogleMap;

            //gmap.ShowCenter = false;
            gMapControl1.MinZoom = 4;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 12;
            gMapControl1.Position = new PointLatLng(53.8, -1.6); // Centered on Leeds
            gMapControl1.DragButton = MouseButtons.Left;

            aircraftOverlay = new GMapOverlay("aircrafts");
            airportOverlay = new GMapOverlay("airports");

            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;


            redPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

            GMapMarker markerT = new GMarkerGoogle(new PointLatLng(52.7888, -1.2095), new Bitmap("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png"));
            markerT.ToolTipText = "Hello There";
            // GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(53.7888, -1.2090), new Bitmap("C:\\Users\\ianct\\source\\repos\\ProductionProject\\PlaneBlueStripeTopView.jpg"));



            aircraftOverlay.Markers.Add(markerT);
            // aircraftOverlay.Markers.Add(marker1);


            gMapControl1.Overlays.Add(aircraftOverlay);
            gMapControl1.Overlays.Add(airportOverlay);


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

                updateFlights(flightList);
                flightPath(flightList);
                drawAirport();
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

                updateFlights(flightList);


            }
            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }


        private void updateFlights(List<flightsInfo> flights)
        {
            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {

                    var marker = aircraftOverlay.Markers.OfType<flightMarker>().FirstOrDefault(m => (string)m.Tag == flight.icao24);

                    if (marker == null)
                    {
                        marker = new flightMarker(new PointLatLng(flight.latitude, flight.longitude), redPlaneIcon,
                            (float)flight.true_track)
                        {
                            Tag = flight.icao24,
                            ToolTipText = flight.callsign

                        };

                        aircraftOverlay.Markers.Add(marker);
                        Debug.WriteLine($"ICAO: {marker.Tag}, Lat: {marker.Position.Lat}, Lng: {marker.Position.Lng}");
                    }

                    else
                    {
                        marker.Position = new PointLatLng(flight.latitude, flight.longitude);
                        marker.planeDirection = (float)flight.true_track;
                        marker.ToolTipText = flight.callsign;
                    }
                }
                gMapControl1.Refresh();
            }
        }

        private void drawAirport()
        {

            List<PointLatLng> airportPoints = new List<PointLatLng>
            {
                new PointLatLng(53.874490, -1.670046), // Leeds Bradford Airport
                new PointLatLng(53.872824, -1.673219),
                new PointLatLng(53.857594, -1.650133),
                new PointLatLng(53.859197, -1.647613),
                new PointLatLng(53.866195, -1.648335),
                new PointLatLng(53.869789, -1.649418)
            };

            GMapPolygon LdsAirport = new GMapPolygon(airportPoints, "Leeds Bradford Airport");
            airportOverlay.Polygons.Add(LdsAirport);
            LdsAirport.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
            //gmap.Overlays.Add(airportOverlay);
        }

        private void drawDetectArea()
        {
            airportOverlay.Polygons.Clear();
            List<PointLatLng> detectAreaPoints = new List<PointLatLng>
            {
                new PointLatLng(54.0, -2.0), // Top-left corner
                new PointLatLng(54.0, 0.0), // Top-right corner
                new PointLatLng(53.6, 0.0), // Bottom-right corner
                new PointLatLng(53.6, -2.0) // Bottom-left corner
            };
            GMapPolygon detectArea = new GMapPolygon(detectAreaPoints, "Detection Area");
            airportOverlay.Polygons.Add(detectArea);
            detectArea.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
        }
        private void flightPath(List<flightsInfo> flights)
        {

            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {


                    List<PointLatLng> points = new List<PointLatLng>();
                    PointLatLng startPoint = new PointLatLng(flight.latitude, flight.longitude);
                    points.Add(new PointLatLng(flight.latitude, flight.longitude));
                    //points.Add(new PointLatLng(flight.latitude + 0.01, flight.longitude + 0.01)); // Example next point
                    GMapRoute route = new GMapRoute(points, flight.callsign);
                    route.Stroke = new Pen(Color.Blue, 2);
                    aircraftOverlay.Routes.Add(route);
                }

            }
            gMapControl1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flightPath(flightList);
            
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
                drawDetectArea();
            }
            else { 
               airportOverlay.Polygons.Clear();
                drawAirport();
            }
        }

        
    }
}
