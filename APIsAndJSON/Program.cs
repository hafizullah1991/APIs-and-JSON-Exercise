using System;
using Newtonsoft.Json.Linq;
namespace APIsAndJSON
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            // Loop to generate quotes
            //for (int i = 0; i < 5; i++)
            //{
            //    // Get Kanye quote and print
            //    string kanyeQuote = RonVSKanyeAPI.KenyeQoute();
            //    Console.WriteLine($"Kanye: {kanyeQuote}");

            //    // Get Ron Swanson quote and print
            //    string ronQuote = RonVSKanyeAPI.RonQuote();
            //    Console.WriteLine($"Ron Swanson: {ronQuote}");
            //}
                OpenWeatherMapAPI api = new OpenWeatherMapAPI();
           
                api.WeatherAPP();
            
            
         
           
        }

    }
}
