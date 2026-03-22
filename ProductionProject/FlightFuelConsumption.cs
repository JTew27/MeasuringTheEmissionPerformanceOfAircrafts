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
using System.Security.Cryptography.X509Certificates;
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
            fuelData data = GetFuelFLowData(typecode);
            double fuelFlow = calculatecCurrentFuelFlow(data);
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
                        //GetFuelFLowData(typecode);
                        return typecode;
                    }
                   // string typecode = aircraftDatabase.GetField("'typecode'");

                   
                }
               
            }

           
            return null;

        }

        public fuelData GetFuelFLowData(string typecode)
        {
            Debug.WriteLine($"Retrieving Fuel FLow Data for {typecode}");

            var defaultD = new fuelData
            {
                //default estimate fyel flow
                fuelFlowTakeOff = "0.937564901",
                fuelFlowCruise = "1.976761168",
                fuelFlowApproach = "1.395479484",
            };


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
                        var data = new fuelData
                        {
                            fuelFlowTakeOff = fuelFlowData.GetField("Fuel Flow T/O (kg/sec)")?.Trim(),
                            fuelFlowCruise = fuelFlowData.GetField("Fuel Flow C/O (kg/sec)")?.Trim(),
                            fuelFlowApproach = fuelFlowData.GetField("Fuel Flow App (kg/sec)")?.Trim(),
                            engineCount = fuelFlowData.GetField("Engine Number")?.Trim(),


                        };
                        Debug.WriteLine($"DB Fuel Flow: TakeOff- {data.fuelFlowTakeOff}, Cruise- {data.fuelFlowCruise}, Approach- {data.fuelFlowApproach} for {id} typecode ");
                        //  calculatecCurrentFuelFlow(data);
                        return data;
                    }
                }
            }
            Debug.WriteLine($"default: no data in db for this typecode:{typecode}");
            return defaultD;
        }

        public double calculatecCurrentFuelFlow(fuelData data) 
        {
            
            double.TryParse(data.fuelFlowTakeOff, out double ffTakeOff);
            double.TryParse(data.fuelFlowCruise, out double ffCruise);
            double.TryParse(data.fuelFlowApproach, out double ffApproach);
            double.TryParse(data.engineCount, out double engine);

            double fuelFlowPerEngine;

            string icao24 = this.fInfo.icao24;
            string callsign = this.fInfo.callsign;

            double verticalRate = fInfo.vertical_rate;

            double velocity = fInfo.velocity;



            Debug.WriteLine($"Vertical Rate: {verticalRate} m/s for: {callsign}");

            if (verticalRate < -2.0) 
            {
                fuelFlowPerEngine = ffApproach;
            }

            else if (verticalRate > 0.5) 
            {
                fuelFlowPerEngine = ffTakeOff;
            }

            else 
            {
                fuelFlowPerEngine = ffCruise;   
            }

            double fuelFlow = fuelFlowPerEngine * engine;

            Debug.WriteLine($"Fuel Flow: {fuelFlowPerEngine} kg/sec for: {icao24} with callsign: {callsign}");
            return fuelFlow;
        }
    }


}
