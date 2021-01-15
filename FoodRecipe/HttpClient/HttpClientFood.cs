//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace FoodRecipe.HttpClient
//{
//    public class HttpClientFood
//    {
//        private readonly HttpClientFood client;
//        private const string BaseAddress = "http://api.weatherstack.com";
//        private const string apiKey = "a831651301512514df5db8dab9f885d5";
//        public WeatherStackClient(HttpClient client)
//        {
//            this.client = client;
//            this.client.BaseAddress = new Uri(BaseAddress);
//            this.client.DefaultRequestHeaders
//                       .Add("Accept", "application/json");
//        }
//        public WeatherInfo GetCurrentWeather(string city)
//        {
//            var httpResponse = client.GetAsync("current" + $"?access_key={apiKey}&query={city}").Result;
//            httpResponse.EnsureSuccessStatusCode();
//            if (!httpResponse.IsSuccessStatusCode)
//            {
//                return null;
//            }
//            WeatherInfo result;
//            using (HttpContent content = httpResponse.Content)
//            {

//                string stringContent = content.ReadAsStringAsync()
//                                               .Result;

//                result = JsonSerializer.Deserialize<WeatherInfo>(stringContent);
//            }
//            return result;
//        }
//    }
//}
