using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProductionProject
{

    public class apiWAuthorisation
    {

        public static async Task<List<flightsInfo>> FetchFlightDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                Token token = await getToken(client);
                return await GetStatesAsync(client, token.AccessToken);
            }
        }

      
        public static async Task<Token> getToken(HttpClient client)
        {

            string baseAddress = "https://auth.opensky-network.org/auth/realms/opensky-network/protocol/openid-connect/token";

            string grant_type = "client_credentials";
            string client_id = "jtew-api-client";
            string REMOVED = "etSfC0ftIAQLzCN4L4GcI5aPQ3IdlijA";


            var requestBody = new Dictionary<string, string>
            {
                { "grant_type", grant_type },
                { "client_id", client_id },
                { "REMOVED", REMOVED }
            };

            HttpResponseMessage response = await client.PostAsync(baseAddress, new FormUrlEncodedContent(requestBody));
            var responseJson = await response.Content.ReadAsStringAsync();
            Token Token = JsonConvert.DeserializeObject<Token>(responseJson);


            return Token;


        }


        public class Token
        {

            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }

            public DateTime ExpirationTime { get; set; }
        }
 

        public static async Task<List<flightsInfo>> GetStatesAsync(HttpClient client, string accessToken)
        {
            Debug.WriteLine("\nNew Response\nRetrieving current flight states ");
            var url = "https://opensky-network.org/api/states/all?lamin=53.6&lomin=-2.0&lamax=54.0&lomax=0.0";

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            var parsed = JToken.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

           ;

            List<flightsInfo> flightList = new List<flightsInfo>();
            foreach (JArray obj in parsed["states"])
            {
               DateTimeOffset timePosUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[3]);
                string timePos = timePosUnix.ToString("HH:mm:ss");

                DateTimeOffset lastContactUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[4]);
                string lastContact = lastContactUnix.ToString("HH:mm:ss");


                flightList.Add(new flightsInfo
                {
                    icao24 = (string)obj[0],
                    callsign = (string)obj[1],
                    origin_country = (string)obj[2],
                    time_position = timePos,
                    last_contact = lastContact,
                    longitude = (double)(obj[5] ?? 0),
                    latitude = (double)(obj[6] ?? 0),
                    on_ground = (bool)(obj[8] ?? false),
                    true_track = (double)(obj[10] ?? 0),
                });
                
            }
            return flightList;
        }

        public static async  Task<List<airportDepartures>> GetDeparturesAsync(HttpClient client, string accessToken)
        {
            string airport = "EGNM";

            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 7200; // last 2 hours

            Debug.WriteLine("Retrieving current flight departures ");
            var url = "https://opensky-network.org/api/flights/departure"+$"?airport={airport}&begin={begin}&end={end}";

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            //var _httpClient = new HttpClient();

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();

            var parsed = JArray.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            List<airportDepartures> departureList = new List<airportDepartures>();

            foreach (JObject obj in parsed)
            {
                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["firstSeen"] ?? 0));
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["lastSeen"] ?? 0));

                string firstSeen = firstSeenUnix.ToString("HH:mm:ss");
                string lastSeen = lastSeenUnix.ToString("HH:mm:ss");

                departureList.Add(new airportDepartures
                {
                    icao24 = (string)obj[1],
                    firstSeen = firstSeen,
                    estDepartureAirport = (string)obj[3],
                    lastSeen = lastSeen,
                    estArrivalAirport = (string)obj[5],
                    callsign = (string)obj[6],
                });
            }
            return departureList;
        }
        
        public static async Task<List<airportArrivals>> GetArrivals()
        {
            string airport = "EGNM";

            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 7200; // last 2 hours

            Debug.WriteLine("Retrieving current flight arrivals ");
            var url = "https://opensky-network.org/api/flights/arrival" + $"?airport={airport}&begin={begin}&end={end}";

            var _httpClient = new HttpClient();

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();

            var parsed = JArray.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            List<airportArrivals> arrivalList = new List<airportArrivals>();

            foreach (JObject obj in parsed)
            {
                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj[1] ?? 0));
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj[2] ?? 0));

                string firstSeen = firstSeenUnix.ToString("HH:mm:ss");
                string lastSeen = lastSeenUnix.ToString("HH:mm:ss");

                arrivalList.Add(new airportArrivals
                {
                    icao24 = (string)obj[1],
                    firstSeen = firstSeen,
                    estDepartureAirport = (string)obj[3],
                    lastSeen = lastSeen,
                    estArrivalAirport = (string)obj[5],
                    callsign = (string)obj[6],
                });
            }
            return arrivalList;

        }

        //public static async Task<List<airplanesPath>> getPaths()
        //{

        //}
    }
}

