using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProductionProject
{
    public class flightsInfo
    {
        public string icao24 { get; set; }
        public string callsign { get; set; }
        public string origin_country { get; set; }
        public string time_position { get; set; }
        public string last_contact { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
        public double baro_altitude { get; set; }
        public bool on_ground { get; set; }
        public double velocity { get; set; }
        public double true_track { get; set; }
        public double vertical_rate { get; set; }
        public List<int> sensors { get; set; }
        public double geo_altitude { get; set; }
        public string squawk { get; set; }
        public bool spi { get; set; }
        public int position_source { get; set; }
        public int category { get; set; }
    }
}

