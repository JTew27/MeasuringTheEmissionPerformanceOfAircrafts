using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GMap.NET.Entity.OpenStreetMapGraphHopperRouteEntity;

namespace ProductionProject
{

    public class flightsMap
    {
        //main map rendering
        private GMapControl map;

        //overlays for different map elements
        public GMapOverlay aircraftOverlay;
        public GMapOverlay airportOverlay;
        public GMapOverlay pathOverlay;

        //custom image to replace GMap markers
        private Image redPlaneIcon;

        //store points for flight path
        public List<PointLatLng> points = new List<PointLatLng>();

        //store current clicked on flight passed in from form1
        public string trackedIcao = null;

        public flightsMap(GMapControl map, Image redPlaneIcon)
        {
            //confifure map settings
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 4;
            map.MaxZoom = 20;
            map.Zoom = 12;
            map.Position = new PointLatLng(53.8, -1.6); // Centered on Leeds
            map.DragButton = MouseButtons.Left;

            //initialise overlays for different map elements
            aircraftOverlay = new GMapOverlay("aircrafts");
            airportOverlay = new GMapOverlay("airports");
            pathOverlay = new GMapOverlay("flightPath");

            //add overlays to map
            map.Overlays.Add(aircraftOverlay);
            map.Overlays.Add(airportOverlay);

           // GMapMarker markerT = new GMarkerGoogle(new PointLatLng(52.7888, -1.2095), new Bitmap("C:/Users/ianct/source/repos/ProductionProject/RedPlaneTopView.png"));
            //markerT.ToolTipText = "Hello There";
            // GMapMarker marker1 = new GMarkerGoogle(new PointLatLng(53.7888, -1.2090), new Bitmap("C:\\Users\\ianct\\source\\repos\\ProductionProject\\PlaneBlueStripeTopView.jpg"));

            //aircraftOverlay.Markers.Add(markerT);
            // aircraftOverlay.Markers.Add(marker1);

            this.map = map;
            this.redPlaneIcon = redPlaneIcon;

        }

        /// <summary>
        /// by using the flightInfo object which contains all the relevant data for a flight to be displaed on the map, the method checks if a marker for the flight already exists and either creates a new one or updates the existing one. 
        /// It also removes markers for flights that have not been updated for over 30 seconds to keep the map current.
        /// </summary>
        /// <param name="flights"></param>
        public void updateFlights(List<flightsInfo> flights)
        {
            //ensures the flight has valid longitue and latitude data passed in from the flightInfo object
            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {
                    //checks if a marker for a flight already exists by checking the icaco number field in the flight object matches whats already in aircraft overlay
                    var marker = aircraftOverlay.Markers.OfType<flightMarker>().FirstOrDefault(m => ((flightsInfo)m.Tag).icao24 == flight.icao24);

                    //if there is no marker for the flight already one is created
                    if (marker == null)
                    {
                        marker = new flightMarker(new PointLatLng(flight.latitude, flight.longitude), redPlaneIcon,
                            (float)flight.true_track)
                        {
                            Tag = flight,
                            ToolTipText = ($"{flight.callsign}at {flight.last_contact}")

                        };

                        aircraftOverlay.Markers.Add(marker);
                        //points.Add(new PointLatLng(flight.latitude, flight.longitude));
                        Debug.WriteLine($"ICAO: {marker.Tag}, Lat: {marker.Position.Lat}, Lng: {marker.Position.Lng}");
                    }

                    //update existing matker
                    else
                    {
                        marker.Position = new PointLatLng(flight.latitude, flight.longitude);
                        marker.planeDirection = (float)flight.true_track;
                        marker.ToolTipText = ($"{flight.callsign}at {flight.last_contact}");
                        marker.Tag = flight;

                        //update flight path if the flight object is the one that has been clicked
                        if (trackedIcao != null && trackedIcao == flight.icao24)
                        {
                            points.Add(marker.Position);
                            pathOverlay.Routes.Clear();
                            GMapRoute route = new GMapRoute(points, "Flight Path");
                            route.Stroke = new System.Drawing.Pen(System.Drawing.Color.Blue, 2);
                            pathOverlay.Routes.Add(route);
                            map.Refresh();
                        }
                    }
                }
                //remove markers that have not been updated for tjhe last 30 seconds to keep the map current
                long time = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                var expiredMarkers = aircraftOverlay.Markers.OfType<flightMarker>().Where(m => time - ((flightsInfo)m.Tag).lastContactUnix > 30).ToList();
                foreach (var expiredMarker in expiredMarkers)
                {
                    aircraftOverlay.Markers.Remove(expiredMarker); 
                }

                map.Refresh();
            }
        }
            

        public void drawAirports()
        {
            //define a polygon area that represents leeds bradford airport that uses these points to draw the shape of the airport on the map,
            //then adds a marker in the center of the airport with a tooltip that displays the name and ICAO code of the airport.
            //This process is repeated for Manchester and Newcastle airports.
            List<PointLatLng> LdsAirportPoints = new List<PointLatLng>
            {
                new PointLatLng(53.874490, -1.670046), // Leeds Bradford Airport
                new PointLatLng(53.872824, -1.673219),
                new PointLatLng(53.857594, -1.650133),
                new PointLatLng(53.859197, -1.647613),
                new PointLatLng(53.866195, -1.648335),
                new PointLatLng(53.869789, -1.649418)
            };
            //define polygon and add it to the overlay
            GMapPolygon LdsAirport = new GMapPolygon(LdsAirportPoints, "Leeds Bradford Airport");
            airportOverlay.Polygons.Add(LdsAirport);
            LdsAirport.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));

            //define a marker to show the location of airport and its ICAO so it can be searched
            var LdsAirportMarker = new GMarkerGoogle(new PointLatLng(53.867909, -1.659546), GMarkerGoogleType.blue_pushpin); 
            LdsAirportMarker.ToolTipText = "Leeds Bradford Airport | EGNM ";
            airportOverlay.Markers.Add(LdsAirportMarker);


            //Manchester Airport
            List<PointLatLng> ManAirportPoints = new List<PointLatLng>
            {
                new PointLatLng(53.330454, -2.311746), // Manchester Airport
                new PointLatLng(53.333417, -2.313830),
                new PointLatLng(53.345801, -2.295570),
                new PointLatLng(53.364103, -2.292891),
                new PointLatLng(53.369847, -2.283364),
                new PointLatLng(53.365406, -2.271256),
                new PointLatLng(53.360787, -2.253691)
            };
            GMapPolygon McAirport = new GMapPolygon(ManAirportPoints, "Manchester Airport");
            airportOverlay.Polygons.Add(McAirport);
            McAirport.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));

            var McAirportMarker = new GMarkerGoogle(new PointLatLng(53.358299, -2.276417), GMarkerGoogleType.blue_pushpin);
            McAirportMarker.ToolTipText = "Manchester Airport | EGCC ";
            airportOverlay.Markers.Add(McAirportMarker);


            //Newcastle Airport

            List<PointLatLng> NewcAirportPoints = new List<PointLatLng>
            {
                new PointLatLng(55.031923, -1.707349), // Newcastle Airport
                new PointLatLng(55.040966, -1.716094),
                new PointLatLng(55.041636, -1.701396),
                new PointLatLng(55.038804, -1.700826),
                new PointLatLng(55.043816, -1.674068),
                new PointLatLng(55.041990, -1.672882)
                
            };
            GMapPolygon NewcAirport = new GMapPolygon(NewcAirportPoints, "Newcastle Airport");
            airportOverlay.Polygons.Add(NewcAirport);
            NewcAirport.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));

            var NewcAirportMarker = new GMarkerGoogle(new PointLatLng(55.037808, -1.706857), GMarkerGoogleType.blue_pushpin);
            NewcAirportMarker.ToolTipText = "Newcastle Airport | EGNT ";
            airportOverlay.Markers.Add(NewcAirportMarker);
            map.Refresh();
            //gmap.Overlays.Add(airportOverlay);
        }

        public void drawDetectArea()
        {
            //clears existing polygons from airport overlay before drawing a new one to represent the detection area of 
            //the map that is being requested from the API
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
        public void flightPath(List<flightsPath> path, string trackedIcao)
        {
            //clear previous flight path line
            points.Clear();
            Debug.WriteLine("Attempting to draw flight path");
            pathOverlay.Routes.Clear();
            pathOverlay.Markers.Clear();

            
            //creates a new GMap point for each point in the flight path object
            foreach (var point in path)
            {
                if (point.latitude != 0.0 && point.longitude != 0.0)
                {
                   points.Add(new PointLatLng(point.latitude, point.longitude));
                }

            }

            //Debug.WriteLine($"Path points count: {points.Count}");

            //if there are enough points and the plane hasnt just take off
            if (points.Count > 1)
            {
                //will create a route using the points list and draw the line connecting all points
                GMapRoute route = new GMapRoute(points, "Flight Path");
                route.Stroke = new System.Drawing.Pen(System.Drawing.Color.Blue, 2);
                pathOverlay.Routes.Add(route);

                var startMarker = new GMarkerGoogle(points.First(), GMarkerGoogleType.green_dot);
                startMarker.ToolTipText = "Flight Origin";
                pathOverlay.Markers.Add(startMarker);

                //var endMarker = new GMarkerGoogle(points.Last(), GMarkerGoogleType.red_dot);
                //endMarker.ToolTipText = "End Point";
                //pathOverlay.Markers.Add(endMarker);
                
            }

            
            map.Overlays.Add(pathOverlay);
            map.Refresh();
        }
    }
}
