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

            //api = new API();
           

            this.Load += Form1_Load;

            //gmap = new GMapControl();
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            //gmap.Dock = DockStyle.Fill;
            //gmap.ShowCenter = false;
            gMapControl1.MinZoom = 4;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 12;
            gMapControl1.Position = new PointLatLng(53.8, -1.6); // Centered on Leeds
            gMapControl1.DragButton = MouseButtons.Left;

            aircraftOverlay = new GMapOverlay("aircrafts");
            splitContainer1.Panel1.Controls.Add(gmap);
            gMapControl1.Dock = DockStyle.Fill;


            redPlaneIcon = Image.FromFile("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

            GMapMarker markerT = new GMarkerGoogle(new PointLatLng(52.7888, -1.2095), new Bitmap("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png"));
            markerT.ToolTipText = "Hello There";


           // GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(53.7888, -1.2090), new Bitmap("C:\\Users\\ianct\\source\\repos\\ProductionProject\\PlaneBlueStripeTopView.jpg"));
            
            
            
            aircraftOverlay.Markers.Add(markerT);
           // aircraftOverlay.Markers.Add(marker1);
            
            
           gMapControl1.Overlays.Add(aircraftOverlay);



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
            }

            catch (Exception er)
            {
                Debug.WriteLine("Error: " + er.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Debug.WriteLine("painting");


            //pictureBox1.Image = Bitmap.FromFile("leedsMapDemo.png");

        }
        // private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //   Pen pen = new Pen(Color.Red, 3);
        //   Bitmap myBitmap = new Bitmap("C:/Users/ianct/source/repos/ProductionProject/LeedsMapDemo.png.png");
        //   Graphics g = Graphics.FromImage(myBitmap);
        //   e.Graphics.DrawImage(myBitmap, 0, 0, pictureBox1.Width, pictureBox1.Height);
        //   e.Graphics.DrawEllipse(pen, 230, 100, 500, 500);
        //  }


        private async void Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                flightList = await apiWAuthorisation.FetchFlightDataAsync();
                Debug.WriteLine("API was called");
                dataGridView1.DataSource = null;
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

        private void DrawFlights(List<flightsInfo> flights)
        {
            var redPlaneIcon = ("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png");

            Debug.WriteLine("Drawing Flights");
            aircraftOverlay.Clear();

            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {

                   GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(flight.latitude, flight.longitude), new Bitmap(redPlaneIcon));


                    //GMapMarker marker = new GMarkerGoogle(new PointLatLng(flight.latitude, flight.longitude), GMarkerGoogleType.red_dot);
                    marker1.ToolTipText = flight.callsign;
                    aircraftOverlay.Markers.Add(marker1);

                }
            }
            gMapControl1.Refresh();

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
        private void flightPath(List<flightsInfo> flights)
        {

            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {
                    

                    List<PointLatLng> points = new List<PointLatLng>();
                    PointLatLng startPoint = new PointLatLng(flight.latitude, flight.longitude);
                    PointLatLng nextPoint = new PointLatLng(flight.latitude + 0.01, flight.longitude + 0.01); 
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
        }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            
        }



    
    }
}
