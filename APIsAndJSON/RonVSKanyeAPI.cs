using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static string KenyeQoute()
        {

        HttpClient client = new HttpClient();
        string Kanye = "https://api.kanye.rest";
        string KanyeResponse = client.GetStringAsync(Kanye).Result;
        var kenyaQuote = JObject.Parse(KanyeResponse).GetValue("quote").ToString();

        Console.WriteLine("=======================");
            Console.WriteLine();
            return kenyaQuote;
           
        }
       public static string RonQuote()
        {
            HttpClient client = new HttpClient();
            string Swanson = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
           string   SwansonResponse = client.GetStringAsync(Swanson).Result;
            JArray SwanResult = JArray.Parse(SwansonResponse);

            Console.WriteLine("=======================");
            Console.WriteLine();
            return SwanResult[0].ToString();

        }
    }
}
