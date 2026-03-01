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
        
        public long time { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float baro_altitude { get; set; }

        public float true_track { get; set; }
        public bool on_ground { get; set; }
    }

}
