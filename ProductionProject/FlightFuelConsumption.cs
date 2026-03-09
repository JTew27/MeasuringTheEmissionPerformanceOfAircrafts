using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace ProductionProject
{
    public class FlightFuelConsumption
    {
        flightsInfo fInfo = new flightsInfo();



        public FlightFuelConsumption()
        {
            //flight info from api that could be useful

            string callsign = this.fInfo.callsign;
            double speed = this.fInfo.velocity;
            double baroAltitude = this.fInfo.baro_altitude;
            double geoAltitude = this.fInfo.geo_altitude;
            double verticalRate = this.fInfo.vertical_rate;
            int category = this.fInfo.category;
        }

    }
}
