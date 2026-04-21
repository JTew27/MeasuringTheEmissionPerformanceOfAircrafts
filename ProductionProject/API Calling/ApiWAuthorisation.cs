using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ProductionProject
{
    /// <summary>
    /// All API calls are called here with first authorising my opensky usr account to get a Oauth2 
    /// temporary access token which is then used in the header of the API calls in order for it to be valid
    /// to receive general flight info, airport specifc departures and arrivals and a specifc flight path.
    /// All endpoints provides a different feature for the web app. 
    /// </summary>

    public class apiWAuthorisation
    {
        public double lamin;
        public double lamax;
        public double lomin;
        public double lomax;


        private static HttpClient _httpClient = new HttpClient();
        // temporary token used as a bearer token in each header of API endpoint calls
        private static Token cachedToken;

        /// <summary>
        /// part of older implmentation when there was only one API call
        /// Called in Form1 originally to first authorise credentials then call the API endpoint to get the current
        /// flight states. Since been updated to call authroisation directly in each method 
        /// using await before calling the API to have a valid token to pass
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<List<flightsInfo>> FetchFlightDataAsync(HttpClient client,double lamin,double lamax,double lomin,double lomax)
        {
            //Token token = await getToken(client);
            
            

            return await GetStatesAsync(client, lamin, lamax, lomin, lomax);
        }
        /// <summary>
        /// Called at the start of each endpoint call method to ensure there is a valid token before
        /// sending a request. This bearer tokem is then passed in the header of each HttpClient request 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private static async Task Authorise(HttpClient client)
        {
            //token is called with an await to ensure the method waits for the token to be received before setting token
            Token token = await GetToken(client);
            // set the bearer token in the header of the client for valid API calls
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);
        }

        /// <summary>
        /// Retrieves a temporary Oauth2 token from the opensky auth server endpoint if current token has expired
        /// </summary>
        /// <param name="client">The HttpCLient c# library used to make http requests</param>
        /// <returns></returns>
        public static async Task<Token> GetToken(HttpClient client)
        {
            //checks if the current token is still valid and returns it
            //checks if the token is not not null and has not expired by comparing the
            //current time to the expriration time received on the token
            if (cachedToken != null && cachedToken.ExpirationTime > DateTime.UtcNow)
            {
                return cachedToken;
            }
            //opensky authroisation that needs to be called as REST API documentation says 
            string baseAddress = "https://auth.opensky-network.org/auth/realms/opensky-network/protocol/openid-connect/token";
            string grant_type = "client_credentials";
            string client_id = "jtew-api-client";
            string REMOVED = "etSfC0ftIAQLzCN4L4GcI5aPQ3IdlijA";
            ///request body is stored as a dictionary with each key being credtionals to be passed in the header of 
            /// the POST request to the auth server endpoint to get the token
            var requestBody = new Dictionary<string, string>
     {
         { "grant_type", grant_type },
         { "client_id", client_id },
         { "REMOVED", REMOVED }
     };

            //POST request is sent to the token endpoint with the requst body of opensky credentials
            HttpResponseMessage response = await client.PostAsync(baseAddress, new FormUrlEncodedContent(requestBody));
            response.EnsureSuccessStatusCode();// throws an exception if the response status code is not 200-299
            ///response content is read as a string and then deserialized into a Token object using the Newtonsoft.Json library
            string responseJson = await response.Content.ReadAsStringAsync();
            Token token = JsonConvert.DeserializeObject<Token>(responseJson);
            //expiration time is calculated by taking the current time and adding the expires_in value from the token response
            token.ExpirationTime = DateTime.UtcNow.AddSeconds(token.ExpiresIn - 30);
            //store the temporary token so it can be caled when the start of the method runs again with each new request 
            cachedToken = token;
            return token;
        }

        /// <summary>
        /// Oauth2 access token classs to store the access token, token type, expires in and expiration time
        /// for the token to be used in the header of API calls
        /// </summary>

        public class Token
        {
            //the bearer token passed in
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }
            //the type of token received from the auth server
            [JsonProperty("token_type")]
            public string TokenType { get; set; }
            [JsonProperty("expires_in")]
            public int ExpiresIn { get; set; }
            public DateTime ExpirationTime { get; set; }
        }

        /// <summary>
        /// Retrieves current aircraft state vectors from the opensky based off passed in location 
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static async Task<List<flightsInfo>> GetStatesAsync(HttpClient client,double lamin, double lamax, double lomin, double lomax)
        {
            Debug.WriteLine("\nNew Response\nRetrieving current flight states ");

            //calls the authorisation method to ensure there is a valid token before sending the request to the API endpoint
            await Authorise(client);


            //API endpoint that will be called with passed in bounding parameters to get states in specifc area
            var url = "https://opensky-network.org/api/states/all?extended=1"+ $"&lamin={lamin}&lomin={lomin}&lamax={lamax}&lomax={lomax}";
            //API call GET request is sent to the endpoint with client header containign the bearer token defined 
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            //start of newtonsoft JSON parsing of the response 
            // reads response body as a string and then parses it into a JToken object which allows for easy access to the JSON properties and values
            string responseJson = await response.Content.ReadAsStringAsync();
            var parsed = JToken.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            //instantiates a new list of flightsInfo objects to store the flight data retrieved from the API response
            List<flightsInfo> flightList = new List<flightsInfo>();

            //splits the JSON array into each a seperate object for each flight where each field can be defined correctly based off Documentation
            foreach (JArray obj in parsed["states"])
            {
                TimeZoneInfo uk = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                // converts the time_position and last_contact fields from unix time to a readbale format
                DateTimeOffset timePosUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[3]);
                string timePos = TimeZoneInfo.ConvertTime(timePosUnix, uk).ToString("HH:mm:ss");

                DateTimeOffset lastContactUnix = DateTimeOffset.FromUnixTimeSeconds((long)obj[4]);
                string lastContact = TimeZoneInfo.ConvertTime(lastContactUnix, uk).ToString("HH:mm:ss");


                flightList.Add(new flightsInfo//index in api doc
                {
                    icao24 = (string)obj[0],//0 - unique 24-bit identifier icao address
                    callsign = (string)obj[1],//1 - flight callsign
                    origin_country = (string)obj[2],//2 - where the aircraft is registered
                    time_position = timePos,//3 - time of last position update from flight in readable format
                    last_contact = lastContact,//4 - time of last update in readable format
                    lastContactUnix = (long)obj[4],//4 for calculating expired markers

                    //can be null so defaults to 0 to avoid errors 
                    longitude = (double)(obj[5] ?? 0),//5 - position longitude in decimal degrees of specifc flight
                    latitude = (double)(obj[6] ?? 0),//6 - position latitude in decimal degrees of specifc flight
                    on_ground = (bool)(obj[8] ?? false),//8 - a boolean value indicating whether the aircraft is on the ground or not
                    true_track = (double)(obj[10] ?? 0),//10 - the decimal degress od the plane direction also needed in flight marker for positioning
                    velocity = (float)(obj[9] ),//9 speed in m/s

                    // Value<float?>() is used to handle null values that were throwing exceptions if 0
                    geo_altitude = obj[13].Value<float?>() ?? 0f,//13 - geometric altitude in meters of specifc flight
                    baro_altitude = obj[7].Value<float?>() ?? 0f,//7  - barometric altitude in meters of specifc flight
                    vertical_rate = obj[11].Value<float?>() ?? 0f,//11 - used for determinging flight phase

                    category = (int)(obj[17]??0),//17- aircraft category that has key in doc but defaults to 0 as this is not always given so causes index out of range error
                });

            }
            return flightList; 
        }

        /// <summary>
        /// Retrieves departures of passed in icaocode of an airport entered by the user from the opensky API endpoint 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="userSearch"></param>
        /// <returns></returns>
        public static async Task<List<airportDepartures>> GetDepartures(HttpClient client, string userSearch)
        {
            //ensure there is a valid Oauth2 token before making a request
            await Authorise(client);
            
            //define time window
            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 86400; 
            //API rewuest URL with passsed in airport ICAO
            Debug.WriteLine("Retrieving current flight departures ");
            var url = "https://opensky-network.org/api/flights/departure" + $"?airport={userSearch}&begin={begin}&end={end}";
            //Send HTTP GET request
            var response = await client.GetAsync(url);
            //throws an exception if the entered parameter is not a valid ICAO code for an airport or if there is an issue with
            //the API call and shows a message box with the error message
            try
            {
                response.EnsureSuccessStatusCode();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve Departure for airport: {userSearch}. Please check the ICAO code and try again.\n API Response: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //read respnse as a string
            string responseJson = await response.Content.ReadAsStringAsync();
            //parse response to a JSON array
            var parsed = JArray.Parse(responseJson);
            //Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));
            //list to store the departure objects created from the API response
            List<airportDepartures> departureList = new List<airportDepartures>();
            foreach (JObject obj in parsed)
            {
                TimeZoneInfo uk = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                // converts the firstSeen and lastSeen fields from unix time to a readable format
                long firstSeenJson = obj["firstSeen"]?.Value<long?>() ?? 0;
                long lastSeenJson = obj["lastSeen"]?.Value<long?>() ?? 0;
                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds(firstSeenJson);
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds(lastSeenJson);
                

                string firstSeen = TimeZoneInfo.ConvertTime(firstSeenUnix, uk).ToString("HH:mm:ss");
                string lastSeen = TimeZoneInfo.ConvertTime(lastSeenUnix, uk).ToString("HH:mm:ss");
                //Json fields to departure object class
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
        /// <summary>
        /// Attempts to retreve the arrivals of an airports based off the airports icao code entered by the user
        /// </summary>
        /// <param name="client"></param>
        /// <param name="userSearch"></param>
        /// <returns></returns>
        public static async Task<List<airportArrivals>> GetArrivals(HttpClient client, string userSearch)
        {
            //ensure there is a valid Oauth2 token before making a request
            await Authorise(client);
            //EGNM - Leeds ICAO
            //EGCC - Manchester ICAO

            //define time window for API request
            long end = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            long begin = end - 86400; 
            //86400 seconds in 24 hours
            //28800 seconds in 8 hours 

            Debug.WriteLine("Retrieving current flight arrivals for "+ userSearch);
            //request URL with passed in search parameter
            var url = "https://opensky-network.org/api/flights/arrival" + $"?airport={userSearch}&begin={begin}&end={end}";
            //Send HTTP GET request
            var response = await client.GetAsync(url);

            try
            {
                response.EnsureSuccessStatusCode();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve arrivals for airport: {userSearch}. Please check the ICAO code and try again.\n API Response: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //read respnse as a string
            string responseJson = await response.Content.ReadAsStringAsync();
            //parse response to a JSON array
            var parsed = JArray.Parse(responseJson);
            //Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));
            //list to store the arrival objects created from the API response
            List<airportArrivals> arrivalList = new List<airportArrivals>();
            //splits the JSON array into each a seperate object for each flight where each field can be defined correctly based off Documentation
            foreach (JObject obj in parsed)
            {
                TimeZoneInfo uk = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
                // converts the firstSeen and lastSeen fields from unix time to a readbale format
                long firstSeenJson = obj["firstSeen"]?.Value<long?>() ?? 0; 
                long lastSeenJson = obj["lastSeen"]?.Value<long?>() ?? 0;

                DateTimeOffset firstSeenUnix = DateTimeOffset.FromUnixTimeSeconds(firstSeenJson); 
                DateTimeOffset lastSeenUnix = DateTimeOffset.FromUnixTimeSeconds(lastSeenJson);

                string firstSeen = TimeZoneInfo.ConvertTime(firstSeenUnix, uk).ToString("HH:mm:ss ddd,dd");
                string lastSeen = TimeZoneInfo.ConvertTime(lastSeenUnix, uk).ToString("HH:mm:ss ddd,dd");

                //Json fields to arrival object class
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

        /// <summary>
        /// Calling the flights endpoint which provides a track history of a list of 15 min interval points of a flights journey
        /// so that it can be drawn as a line 
        /// </summary>
        /// <param name="client"></param>
        /// <param name="icao"></param>
        /// <param name="last_contact"></param>
        /// <returns></returns>
        public static async Task<List<flightsPath>> GetFlightPath(HttpClient client, string icao, long last_contact)
        {
            //ensure there is a valid Oauth2 token before making a request
            await Authorise(client);

            //define url endpoint that is being called - time = 0 returns the most recent points
            Debug.WriteLine("Retrieving current flight tracks for "+icao);
            var url = "https://opensky-network.org/api/tracks/all" + $"?icao24={icao}&time=0";
            //Send HTTP GET request
            var response = await client.GetAsync(url);
            //error handling to catch failed API calls
            if (!response.IsSuccessStatusCode)
            {
                Debug.WriteLine($"flight path - Failed to call:{response.StatusCode}");
            }
            //read JSON repsonse
            string responseJson = await response.Content.ReadAsStringAsync();

            //handle empty response meaning there is no track data available
            if (string.IsNullOrEmpty(responseJson))
            {
                Debug.WriteLine("Response content is empty.");
                return new List<flightsPath>();
            }
            // parse JSON object
            JObject obj = JObject.Parse(responseJson);
            //Debug.WriteLine(obj.ToString(Newtonsoft.Json.Formatting.Indented));

            //List to store the flight path points created from the API response
            List<flightsPath> flightPathList = new List<flightsPath>();
            //extract the path array from the JSON object which contains the track points of the
            //flight and loop through each point to create a flightsPath object with
            //the relevant fields for each point and add it to the list to be returned
            JArray pathArray = (JArray)obj["path"];
            //iterate throught each flight point
            foreach (JArray p in pathArray)
            {
               var point = new flightsPath
               {
                   //general flight info that are the same for each point
                    icao24 = (string)obj["icao24"] ?? "",
                    startTime = (int)(obj["startTime"] ?? 0),
                    endTime = (int)(obj["endTime"] ?? 0),
                    callsign = (string)obj["callsign"] ?? "",
                   // path = (JArray)obj["path"],

                   //unique point info that changes for each point in the path array
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

