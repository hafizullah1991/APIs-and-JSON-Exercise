using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        
        public void WeatherAPP()
        {
            HttpClient client = new HttpClient();
            string apiKey = "be744f1a3c044deffb5fafb55053b6cc";
            Console.WriteLine("type your city name? ");
            string city = Console.ReadLine();

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=imperial";
            var weatherResponse = client.GetStringAsync(url).Result;

         JObject weatherObject = JObject.Parse(weatherResponse);
            Console.WriteLine($" {city} temperature is {weatherObject["main"]["temp"]} degree's Fahrenheit");

         



            

            
        }
       
         

    }
}
