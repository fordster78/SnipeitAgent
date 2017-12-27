using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SnipeSharp;

namespace Agent.Classes
{
    class Api
    {
        static string Token = "";
        static string URI = "";
        static string Company = "";
        static string Category = "";

        private static void ReadValues()
        {
            var config = ConfigurationManager.AppSettings;
            Token = config["API"];
            URI = config["BaseURI"];
            Company = config["Company"];
            Category = config["Category"];
            Console.WriteLine(Token);
            Console.WriteLine(URI);
            Console.WriteLine(Company);
            Console.WriteLine(Category);
        }

        public static SnipeItApi GetAPI()
        {
            ReadValues();

            SnipeItApi API = new SnipeItApi();
            API.ApiSettings.ApiToken = Token;
            API.ApiSettings.BaseUrl = new Uri(URI);

            return API;
        }

        public static string GetCompany()
        {
            ReadValues();

            return Company;
        }

        public static string GetCategory()
        {
            ReadValues();

            return Category;
        }
    }
}
