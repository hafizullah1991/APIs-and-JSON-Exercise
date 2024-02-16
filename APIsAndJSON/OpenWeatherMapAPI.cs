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
        
        public void WeatherAPP(string city)
        {
            HttpClient client = new HttpClient();
            string APIKey = "be744f1a3c044deffb5fafb55053b6cc";
            Console.WriteLine("type your city name ");
            string City = Console.ReadLine();

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={City}&appid={APIKey}";
            var weatherResponse = client.GetStringAsync(url).Result;

            //JObject Response = JObject.Parse(weather1).GetValue("main").ToString();

            dynamic weatherData = JObject.Parse(weatherResponse);
            double tempreture = weatherData.main.temp;
            int humidity = weatherData.main.humidity;
            string cloudDescription = weatherData.weather[0].description;

           

            double tempretureCelsius = tempreture - 273.15;
            double tempretureFhrenheit = tempretureCelsius * 9 / 5 + 32;

            Console.WriteLine($" tempreture in {City} : {tempretureFhrenheit:F2} F");
            
            Console.WriteLine($"Humadity : {humidity}");

            
        }
       
         

    }
}
