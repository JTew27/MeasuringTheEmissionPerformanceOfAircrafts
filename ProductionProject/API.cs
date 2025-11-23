using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;



namespace ProductionProject
{
    public class API
    {

        private HttpClient _httpClient;
        public API()
        {
            _httpClient = new HttpClient();


        }

        public async Task<List<flightsInfo>> GetStatesAsync()
        {
            Debug.WriteLine("Running");
            //states all provides all current state vectors from all aircrafts
            //using bounding box parameters to limit the area to just leeds
            var url = "https://opensky-network.org/api/states/all?lamin=53.6&lomin=-2.0&lamax=54.0&lomax=0.0";

            //leeds
            //?lamin=53.6&lomin=-2.0&lamax=54.0&lomax=0.0

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync(); // convertd to ascynchronus string

            var parsed = JToken.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            //flights flightData = JsonConvert.DeserializeObject<flights>(responseJson);
            
            List<flightsInfo> flightList = new List<flightsInfo>();

            foreach (JArray obj in parsed["states"])
            {
                flightList.Add( new flightsInfo
                {

                 icao24 = (string)obj[0],
                 callsign = (string)obj[1],
                 origin_country = (string)obj[2],
                 time_position = (long)(obj[3] ?? 0),
                 last_contact = (long)(obj[4] ?? 0),
                 longitude = (double)(obj[5] ?? 0),
                 latitude = (double)(obj[6] ?? 0),
                 on_ground = (bool)(obj[8] ?? false),
                });
               
                //Debug.WriteLine($"Callsign:{callsign}, Latitude: {latitude}, Longitude: {longitude}");
                
            }

            //return responseJson;
            return flightList;

        }

        public class Response(string ResponseJson)
        {
            //string json = await api.GetStatesAsync();
            //return JsonSerializer.Deserialize<T>(json);
        }
    }
}
