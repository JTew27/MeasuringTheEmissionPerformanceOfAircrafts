using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
            //Debug.WriteLine($"Typecode: {typecode}");
        }


        public string GetTypecodeByIcao(string icao24)
        {
           

            string path = @"C:\Users\ianct\source\repos\ProductionProject\aircraft-database-complete-2025-08.csv";
            using (var reader = new StreamReader(path))
            using (var aircraftDatabase = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                aircraftDatabase.Read();
                aircraftDatabase.ReadHeader();

                while (aircraftDatabase.Read())
                {
                    string id = aircraftDatabase.GetField("'icao24'")?.Trim('\'');

                    if (id == icao24.Trim())
                    {
                        string typecode = aircraftDatabase.GetField("'typecode'")?.Trim('\'');
                        Debug.WriteLine($"typecode: {typecode} for {id} icao number ");
                        GetFuelFLowData(typecode);
                        //return typecode;
                    }
                   // string typecode = aircraftDatabase.GetField("'typecode'");

                   
                }
               
            }

           
            return null;

        }

        public string GetFuelFLowData(string typecode)
        {
            Debug.WriteLine($"Retrieving Fuel FLow Data for {typecode}");

            string path = @"C:\Users\ianct\source\repos\ProductionProject\AircraftTypeEngineFuelFlowData.csv"; 
            using (var reader = new StreamReader(path))
            using (var fuelFlowData = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                fuelFlowData.Read();
                fuelFlowData.ReadHeader();
                while (fuelFlowData.Read())
                {
                    string id = fuelFlowData.GetField("typecode")?.Trim();
                    if (id == typecode.Trim())
                    {
                        string fuelFlowTakeOff = fuelFlowData.GetField("Fuel Flow T/O (kg/sec)")?.Trim();
                        string fuelFlowCruise = fuelFlowData.GetField("Fuel Flow C/O (kg/sec)")?.Trim();
                        string fuelFlowApproach = fuelFlowData.GetField("Fuel Flow App (kg/sec)")?.Trim();
                        Debug.WriteLine($"Fuel Flow: TakeOff- {fuelFlowTakeOff}, Cruise- {fuelFlowCruise}, Approach- {fuelFlowApproach} for {id} typecode ");

                        return fuelFlowTakeOff;
                    }
                    else if (!(id == typecode.Trim()))
                    {
                        //default estimate fuel flow
                    }
                   
                }
            }
             
            return null;
        }
    }


}
