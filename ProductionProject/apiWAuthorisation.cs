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
            Token token = JsonConvert.DeserializeObject<Token>(responseJson);


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


        public static async Task<List<flightsInfo>> GetStatesAsync(HttpClient client, string accessToken)
        {
            Debug.WriteLine("\nNew Response\nRunning with valid credentials");
            var url = "https://opensky-network.org/api/states/all?lamin=53.6&lomin=-2.0&lamax=54.0&lomax=0.0";

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseJson = await response.Content.ReadAsStringAsync();
            var parsed = JToken.Parse(responseJson);
            Debug.WriteLine(parsed.ToString(Newtonsoft.Json.Formatting.Indented));

            List<flightsInfo> flightList = new List<flightsInfo>();
            foreach (JArray obj in parsed["states"])
            {
                flightList.Add(new flightsInfo
                {
                    icao24 = (string)obj[0],
                    callsign = (string)obj[1],
                    origin_country = (string)obj[2],
                    time_position = (long)(obj[3] ?? 0),
                    last_contact = (long)(obj[4] ?? 0),
                    longitude = (double)(obj[5] ?? 0),
                    latitude = (double)(obj[6] ?? 0),
                    on_ground = (bool)(obj[8] ?? false),
                    true_track = (double)(obj[10] ?? 0),
                });
                
            }
            return flightList;
        }
    }
}

