using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

        public async Task<string> GetStatesAsync()
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

            return responseJson;

        }

        public class Response(string ResponseJson)
        {
            //string json = await api.GetStatesAsync();
            //return JsonSerializer.Deserialize<T>(json);
        }
    }
}
