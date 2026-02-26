using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;

namespace ProductionProject
{

    public class flightsMap
    {


        private GMapControl map;
        public GMapOverlay aircraftOverlay;
        public GMapOverlay airportOverlay;

        private Image redPlaneIcon;


        public flightsMap(GMapControl map, Image redPlaneIcon)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.MinZoom = 4;
            map.MaxZoom = 20;
            map.Zoom = 12;
            map.Position = new PointLatLng(53.8, -1.6); // Centered on Leeds
            map.DragButton = MouseButtons.Left;

            aircraftOverlay = new GMapOverlay("aircrafts");
            airportOverlay = new GMapOverlay("airports");

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

        public void updateFlights(List<flightsInfo> flights)
        {
            foreach (var flight in flights)
            {
                if (flight.latitude != 0.0 && flight.longitude != 0.0)
                {

                    var marker = aircraftOverlay.Markers.OfType<flightMarker>().FirstOrDefault(m => ((flightsInfo)m.Tag).icao24 == flight.icao24);

                    if (marker == null)
                    {
                        marker = new flightMarker(new PointLatLng(flight.latitude, flight.longitude), redPlaneIcon,
                            (float)flight.true_track)
                        {
                            Tag = flight,
                            ToolTipText = ($"{flight.callsign}at {flight.last_contact}")

                        };

                        aircraftOverlay.Markers.Add(marker);
                        Debug.WriteLine($"ICAO: {marker.Tag}, Lat: {marker.Position.Lat}, Lng: {marker.Position.Lng}");
                    }

                    else
                    {
                        marker.Position = new PointLatLng(flight.latitude, flight.longitude);
                        marker.planeDirection = (float)flight.true_track;
                        marker.ToolTipText = ($"{flight.callsign}at {flight.last_contact}");
                        marker.Tag = flight;
                    }
                }
            }
                long time = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                var expiredMarkers = aircraftOverlay.Markers.OfType<flightMarker>().Where(m => time - ((flightsInfo)m.Tag).lastContactUnix > 30).ToList();
                foreach (var expiredMarker in expiredMarkers)
                {
                    aircraftOverlay.Markers.Remove(expiredMarker);
                }   
            
            map.Refresh();
        }

        public void drawAirport()
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

        public void drawDetectArea()
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
        public void flightPath(List<flightsInfo> flights)
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
            map.Refresh();
        }
    }
}
