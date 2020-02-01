using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;
using Newtonsoft.Json;

namespace EestiAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to facts about Estonia!");
            EstFacts();
        }

        public static void EstFacts()
        {
            string EstFactsUrl = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EstFactsUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                var eeInfo = JsonConvert.DeserializeObject<List<info.Country>>(response);
                foreach (var land in eeInfo)
                {
                    Console.WriteLine($"Namr: {land.Name}");
                    Console.WriteLine($"Capital: {land.Capital}");
                    Console.WriteLine($"Country code: {land.Cioc}");
                    Console.WriteLine($"Region: {land.Region}");
                    Console.WriteLine($"Population: {land.Population}");

                    foreach (var lang in land.Languages)
                    {
                        Console.WriteLine($"Language:{lang.Name}");
                    }
                    foreach (var domeen in land.TopLevelDomain)
                    {
                        Console.WriteLine($"Domain:{land.TopLevelDomain[0]}");
                    }
                }
            }
        }

    }
}
