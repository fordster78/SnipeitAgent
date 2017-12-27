using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnipeSharp;
using SnipeSharp.Endpoints.SearchFilters;
using SnipeSharp.Endpoints.Models;
using Agent.Classes;

namespace Agent.Classes.Models
{
    class MyManufacturer
    {
        static string Name = "";

        public static string Find(string DeviceMake)
        {
            string Make = DeviceMake;
            
            SnipeItApi Snipe = Api.GetAPI();

            SearchFilter Search = new SearchFilter
            {
                Search = Make
            };

            try
            {
                Name = Snipe.ManufacturerManager.FindOne(Search).Name;
                return Name;
            }
            catch(ArgumentOutOfRangeException)
            {
                string device = Create(Make);
                Name = $"Created: {device}";
                return Name;
            }
        }

        private static string Create(string DeviceMake)
        {
            string Make = DeviceMake;
            
            SnipeItApi Snipe = Api.GetAPI();
            Manufacturer maker = new Manufacturer
            {
                Name = Make
            };
            Snipe.ManufacturerManager.Create(maker);

            Name = Snipe.ManufacturerManager.Get(Make).Name;

            return Name;
        }
    }
}
