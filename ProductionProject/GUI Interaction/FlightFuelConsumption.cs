using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
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

        public double fuelFlow { get; private set; }
        public string flightPhase {  get; private set; }
        public string typecode { get; private set; }
        public fuelData fuelData { get; private set; }

        int counter = 0;
        /// <summary>
        /// Constructor method takes the flightinfo object to extract relevant flight data like the 
        /// icao24 address so look up process can start on event click
        /// </summary>
        /// <param name="fInfo"></param>
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
            bool onGround = this.fInfo.on_ground;

            typecode = GetTypecodeByIcao(icao24);
            this.fuelData = GetFuelFLowData(typecode);
            fuelFlow = CalculatecCurrentFuelFlow(this.fuelData,icao24,callsign,verticalRate,speed,onGround, baroAltitude, typecode);
            //Debug.WriteLine($"Typecode: {typecode}");  

        }

        /// <summary>
        /// Search Opensky aircraft database CSV by recieved icao24 address to find the corresponding typecode for that aircraft
        /// </summary>
        /// <param name="icao24"></param>
        /// <returns></returns>
        public string GetTypecodeByIcao(string icao24)
        {
            string path = @"C:\Users\ianct\source\repos\ProductionProject\aircraft-database-complete-2025-08.csv";
            //use of CSV helper library to read the CSV file and search for the matching icao24 address to retrieve the typecode for that aircraft
            using (var reader = new StreamReader(path))
            using (var aircraftDatabase = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                //built in csv functions to read the file and its headers before iterating through the rows to find the matching icao24 address 
                aircraftDatabase.Read();
                aircraftDatabase.ReadHeader();

                while (aircraftDatabase.Read())
                {
                    //strip surrounding single quotes as they were causing problems with finding a match
                    string id = aircraftDatabase.GetField("'icao24'")?.Trim('\'');
                    //return typecode if there is a match very rare there isnt a match since the database is huge
                    if (id == icao24.Trim())
                    {
                        string typecode = aircraftDatabase.GetField("'typecode'")?.Trim('\'');
                        Debug.WriteLine($"typecode: {typecode} for {id} icao number ");
                        //GetFuelFLowData(typecode);
                        //string manufacturer = aircraftDatabase.GetField("'manufacturerIcao'")?.Trim('\'');

                        if (string.IsNullOrEmpty(typecode))
                        {
                            typecode = "Default";
                            Debug.WriteLine("Typecode not founf using default");
                        }


                        return typecode;
                    }
                    // string typecode = aircraftDatabase.GetField("'typecode'");
                   
                }
            }
            //not found

            return "Default" ;
        }
        /// <summary>
        /// Search custom fuel daatabase CSV at the moment contains most common aircraft typecodes and their fuel flow data for takeoff, cruise
        /// and approach phases of flight. 
        /// since havent added every typecode there is a default fuel flow data object that OpenAP also used 
        /// <param name="typecode"></param>
        /// <returns></returns>
        public fuelData GetFuelFLowData(string typecode)
        {
           // counter +=1;
            Debug.WriteLine($"Retrieving Fuel FLow Data for {typecode}");
            //default values utilised if typcode is not matched in database
            var defaultD = new fuelData
            {
                //default estimate fyel flow
                fuelFlowTakeOff = "0.937564901",
                fuelFlowCruise = "1.976761168",
                fuelFlowApproach = "1.395479484",
                fuelFlowIdle = "0.113",
                engineCount = "2"
            };

            //same use of CSV helper library to read first then iterate through to match
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
                            //if there is a typecode match return that rows data and store it in a fuelData object jsut as any other return of data 
                            fuelFlowTakeOff = fuelFlowData.GetField("Fuel Flow T/O (kg/sec)")?.Trim(),
                            fuelFlowCruise = fuelFlowData.GetField("Fuel Flow C/O (kg/sec)")?.Trim(),
                            fuelFlowApproach = fuelFlowData.GetField("Fuel Flow App (kg/sec)")?.Trim(),
                            fuelFlowIdle = fuelFlowData.GetField("Fuel Flow Idle (kg/sec)")?.Trim(),
                            engineCount = fuelFlowData.GetField("Engine Number")?.Trim(),
                           
                        };
                        Debug.WriteLine($"DB Fuel Flow: TakeOff- {data.fuelFlowTakeOff}, Cruise- {data.fuelFlowCruise}, Approach- {data.fuelFlowApproach} for {id} typecode ");
                        //  calculatecCurrentFuelFlow(data);
                        return data;
                    }
                    else if (id == null)
                    {
                        return defaultD;

                    }
                }
                Debug.WriteLine($"default: no data in db for this typecode:{typecode}");

                if (counter == 1)
                {
                   MessageBox.Show($"No fuel flow data in database for this typecode: {typecode} \n Default fuel flow values are applied");
                }
                return defaultD;
            }
        }
        /// <summary>
        /// Determine fuel phase to utilise the correct fuel flow coefficient from the fuel data object 
        /// calculate the fuel flow by multiplying the fuel flow per engine by the number of engines and return that value when called
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public double CalculatecCurrentFuelFlow(fuelData data, string icao24, string callsign, double verticalRate, double velocity, bool onGround, double baroAltitude, string typecode ) 
        {
            //parse the fuel flow data from string to double to be able to do calculations with it
            double.TryParse(data.fuelFlowTakeOff, out double ffTakeOff);
            double.TryParse(data.fuelFlowCruise, out double ffCruise);
            double.TryParse(data.fuelFlowApproach, out double ffApproach);
            double.TryParse(data.engineCount, out double engine);
            double.TryParse(data.fuelFlowIdle, out double ffIdle);

            string flightPhase = "";
            double fuelFlowPerEngine = 0;
            //determing flight phase based of the specifc flights vertical rate 
            Debug.WriteLine($"Vertical Rate: {verticalRate} m/s for: {callsign}");

            if (onGround == true)
            {
                fuelFlowPerEngine = ffIdle;
                flightPhase = "Idle";
            }
            else if (baroAltitude < 1500)
            {
                if (verticalRate < 0)
                {
                    fuelFlowPerEngine = ffApproach;
                    flightPhase = "Approach";
                }
                else
                {
                    fuelFlowPerEngine = ffTakeOff;
                    flightPhase = "Climb";
                }
            }
            else
            {
                // Above 1500m — classify by vertical rate thresholds   
                if (verticalRate < 0)
                {
                    fuelFlowPerEngine = ffApproach;
                    flightPhase = "Descending";
                }
                else if (verticalRate > 2)
                {
                    fuelFlowPerEngine = ffTakeOff;
                    flightPhase = "Climbing";
                }
                else
                {
                    fuelFlowPerEngine = ffCruise;
                    flightPhase = "Cruise";
                }
            }
            //calulate and return 
            double fuelFlow = fuelFlowPerEngine * engine;
            double fuelFlowKgPerHour = fuelFlow * 3600; // Convert kg/sec to kg/hour
            Debug.WriteLine(fuelFlowPerEngine);
            Debug.WriteLine($"Fuel Flow: {fuelFlow} kg/sec for: {icao24} with callsign: {callsign}");
           // MessageBox.Show($"Flight Phase: {flightPhase}\nFuel Flow: {fuelFlowPerEngine} kg/sec \n{icao24} Aircraft Model: {typecode} \nCallsign: {callsign} \n Engines: {engine}");
            this.flightPhase = flightPhase;
            return fuelFlow;
        }
    }


}
