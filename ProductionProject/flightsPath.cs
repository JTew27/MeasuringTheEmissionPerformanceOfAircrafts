using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    public class flightsPath
    {
        public string icao24 { get; set; }
        public int startTime { get; set; }
        public int endTime { get; set; }
        public string callsign { get; set; }
        public string estDepartureAirport { get; set; }
        public string estArrivalAirport { get; set; }
        public List<double[]> path { get; set; }
    }
}
