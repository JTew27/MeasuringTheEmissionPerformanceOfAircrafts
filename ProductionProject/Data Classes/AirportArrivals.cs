using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{
    public class airportArrivals
    {

        public string icao24 { get; set; }
        public string firstSeen { get; set; }
        public string estDepartureAirport { get; set; }
        public string lastSeen { get; set; }
        public string estArrivalAirport { get; set; }
        public string callsign { get; set; }
        public string estDepartureAirportHorizDistance { get; set; }
        public string estDepartureAirportVertDistance { get; set; }
        public string estArrivalAirportHorizDistance { get; set; }
        public string estArrivalAirportVertDistance { get; set; }
        public string departureAirportCandidatesCount { get; set; }
        public string arrivalAirportCandidatesCount { get; set; }


    }
}
