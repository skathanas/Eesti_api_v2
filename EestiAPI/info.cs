using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;

namespace EestiAPI
{
    class info
        
    {
   
                public class Language
            {
                public string Name { get; set; }
            }

            public class Country
            {
                public string Name { get; set; }

                public string Capital { get; set; }

                public string Region { get; set; }

                public string Cioc { get; set; }

                public int Population { get; set; }

                public List<string> TopLevelDomain { get; set; }

                public List<Language> Languages { get; set; }
            }
        }


    }





