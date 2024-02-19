using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class Class1
    {
        public void GethWeatherInfo()
        {

            Console.WriteLine("Enter your city name? ");
            string city = Console.ReadLine();
            HttpClient client = new HttpClient();
            string apiKey = "be744f1a3c044deffb5fafb55053b6cc";

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";
           

            string  urlResponse = client.GetStringAsync(url).Result;
            JObject weatherObject = JObject.Parse(urlResponse);

            Console.WriteLine(weatherObject);
        }
    }
}
