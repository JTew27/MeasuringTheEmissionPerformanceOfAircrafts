using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http.Headers;


namespace ProductionProject
{

    public class apiWAuthorisation
    {
        private static HttpClient _httpClient = new HttpClient();
        private static Token cachedToken;
        public static async Task<List<flightsInfo>> FetchFlightDataAsync()
        {
            using HttpClient client = new HttpClient();
            //Token token = await getToken(client);
            return await GetStatesAsync(client);

        }

        private static async Task Authorise(HttpClient client)
        {
            Token token = await getToken(client);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }
        public static async Task<Token> getToken(HttpClient client)
        {
            if (cachedToken != null && cachedToken.ExpirationTime > DateTime.UtcNow)
            {
                return cachedToken;
            }

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
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            Token token = JsonConvert.DeserializeObject<Token>(responseJson);

            token.ExpirationTime = DateTime.UtcNow.AddSeconds(token.ExpiresIn - 30);

            cachedToken = token;

            return token;


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


        public static async Task<List<flightsInfo>> GetStatesAsync(HttpClient client)
        {
            Debug.WriteLine("\nNew Response\nRetrieving current flight states ");

            await Authorise(client);

            double lamin = 53.6;
            double lomin = -2.0;
            double lamax = 54.0;
            double lomax = 0.0;

            var url = "https://opensky-network.org/api/states/all?extended=1"+ $"&lamin={lamin}&lomin={lomin}&lamax={lamax}&lomax={lomax}";

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();
            var parsed = JToken.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));


            List<flightsInfo> flightList = new List<flightsInfo>();
            foreach (JArray obj in parsed["states"])
            {
                DateTimeOffset timePosUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[3]);
                string timePos = timePosUnix.ToString("HH:mm:ss");

                DateTimeOffset lastContactUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[4]);
                string lastContact = lastContactUnix.ToString("HH:mm:ss");


                flightList.Add(new flightsInfo//index in api doc
                {
                    icao24 = (string)obj[0],//0
                    callsign = (string)obj[1],//1
                    origin_country = (string)obj[2],//2
                    time_position = timePos,//3
                    last_contact = lastContact,//4
                    lastContactUnix = (long)obj[4],//4 for calculating expired markers
                    longitude = (double)(obj[5] ?? 0),//5
                    latitude = (double)(obj[6] ?? 0),//6
                    on_ground = (bool)(obj[8] ?? false),//8
                    true_track = (double)(obj[10] ?? 0),//10
                    velocity = (float)(obj[9] ),//9 only appears some of the time

                    
                    geo_altitude = obj[13].Value<float?>() ?? 0f,//13 both throw cannot convert null to single
                    baro_altitude = obj[7].Value<float?>() ?? 0f,//7 
                    vertical_rate = obj[11].Value<float?>() ?? 0f,//11

                    category = (int)(obj[17]??0),//17 default to 0 as this is not always given so causes index out of range error
                });

            }
            return flightList;
        }

        public static async Task<List<airportDepartures>> GetDepartures(HttpClient client, string userSearch)
        {
            //
            string airport = "EGCC";


            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 7200; // last 2 hours

            await Authorise(client);
            Debug.WriteLine("Retrieving current flight departures ");
            var url = "https://opensky-network.org/api/flights/departure" + $"?airport={userSearch}&begin={begin}&end={end}";

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();

            var parsed = JArray.Parse(responseJson);
            //Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            List<airportDepartures> departureList = new List<airportDepartures>();

            foreach (JObject obj in parsed)
            {
                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["firstSeen"] ?? 0));
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["lastSeen"] ?? 0));

                string firstSeen = firstSeenUnix.ToString("HH:mm:ss");
                string lastSeen = lastSeenUnix.ToString("HH:mm:ss");

                departureList.Add(new airportDepartures
                {
                    icao24 = (string)obj["icao24"],
                    firstSeen = firstSeen,
                    estDepartureAirport = (string)obj["estDepartureAirport"],
                    lastSeen = lastSeen,
                    estArrivalAirport = (string)obj["estArrivalAirport"],
                    callsign = (string)obj["callsign"],
                });
            }
            return departureList;
        }

        public static async Task<List<airportArrivals>> GetArrivals(HttpClient client, string userSearch)
        {
            await Authorise(client);
            //EGNM - Leeds ICAO
            string airport = "EGCC";
            


            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 86400; // last 24 hours

            Debug.WriteLine("Retrieving current flight arrivals for "+ userSearch);
            var url = "https://opensky-network.org/api/flights/arrival" + $"?airport={userSearch}&begin={begin}&end={end}";



            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();

            var parsed = JArray.Parse(responseJson);
            //Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            List<airportArrivals> arrivalList = new List<airportArrivals>();

            foreach (JObject obj in parsed)
            {
                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["firstSeen"] ?? 0));
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds((long)(obj["lastSeen"] ?? 0));

                string firstSeen = firstSeenUnix.ToString("HH:mm:ss ddd,dd");
                string lastSeen = lastSeenUnix.ToString("HH:mm:ss ddd,dd");

                arrivalList.Add(new airportArrivals
                {
                    icao24 = (string)obj["icao24"],
                    firstSeen = firstSeen,
                    estDepartureAirport = (string)obj["estDepartureAirport"],
                    lastSeen = lastSeen,
                    estArrivalAirport = (string)obj["estArrivalAirport"],
                    callsign = (string)obj["callsign"],
                });
            }
            return arrivalList;

        }


        public static async Task<List<flightsPath>> GetFlightPath(HttpClient client, string icao, long last_contact)
        {
            await Authorise(client);

            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long time = end - 14400; // last 4 hours

            Debug.WriteLine("Retrieving current flight tracks for "+icao);
            var url = "https://opensky-network.org/api/tracks/all" + $"?icao24={icao}&time={last_contact}";


            var response = await client.GetAsync(url);
            //response.EnsureSuccessStatusCode();

            if (!response.IsSuccessStatusCode)
            {
                Debug.WriteLine($"Failed to call:{response.StatusCode}");
            }
            string responseJson = await response.Content.ReadAsStringAsync();


            if (string.IsNullOrEmpty(responseJson))
            {
                Debug.WriteLine("Response content is empty.");
                return new List<flightsPath>();
            }
            JObject obj = JObject.Parse(responseJson);
            Debug.WriteLine(obj.ToString(Newtonsoft.Json.Formatting.Indented));


            List<flightsPath> flightPathList = new List<flightsPath>();

            JArray pathArray = (JArray)obj["path"];

            foreach (JArray p in pathArray)
            {
               var point = new flightsPath
               {
                    icao24 = (string)obj["icao24"] ?? "",
                    startTime = (int)(obj["startTime"] ?? 0),
                    endTime = (int)(obj["endTime"] ?? 0),
                    callsign = (string)obj["callsign"] ?? "",
                  // path = (JArray)obj["path"],

                    time = (long)(p[0] ?? 0),
                    latitude = (float)(p[1] ?? 0.0),
                    longitude = (float)(p[2] ?? 0.0),
                    baro_altitude = (float)(p[3] ?? 0.0),
                    true_track = (float)(p[4] ?? 0.0),
                    on_ground = (bool)(p[5] ?? false),
                };
                flightPathList.Add(point);
                //Debug.WriteLine($"Point:{point.time}\nLatitude:{point.latitude}\nLongitude:{point.longitude}\n");
            }
         
            return flightPathList;

          
        }

    }
}

