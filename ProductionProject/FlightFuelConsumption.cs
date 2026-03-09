using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionProject
{

    public class FlightFuelConsumption
    {
        flightsInfo fInfo;



        public FlightFuelConsumption(flightsInfo fInfo)
        {

            this.fInfo = fInfo;

            //flight info from api that could be useful
            string icao24 = this.fInfo.icao24;
            string callsign = this.fInfo.callsign;
            double speed = this.fInfo.velocity;
            double baroAltitude = this.fInfo.baro_altitude;
            double geoAltitude = this.fInfo.geo_altitude;
            double verticalRate = this.fInfo.vertical_rate;
            int category = this.fInfo.category;

            string typecode = GetTypecodeByIcao(icao24);
            Debug.WriteLine($"Typecode: {typecode}");
        }


        public string GetTypecodeByIcao(string icao24)
        {


            string path = @"C:\Users\ianct\Downloads\aircraft-database-complete-2025-08.csv";

            using (var reader = new StreamReader(path))
            using (var aircraftDatabase = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                aircraftDatabase.Read();
                aircraftDatabase.ReadHeader();

                while (aircraftDatabase.Read())
                {
                    string id = aircraftDatabase.GetField("'icao24'");

                    if (id == icao24.Trim())
                    {
                        string typecode = aircraftDatabase.GetField("'typecode'")?.Trim('\'');
                        Debug.WriteLine($"typecode: {typecode} for {id} icao number ");
                        return typecode;
                    }
                   // string typecode = aircraftDatabase.GetField("'typecode'");

                   
                }
               
            }

            return null;

        }
    }
}
