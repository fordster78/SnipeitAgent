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
    class MyAssetModel
    {
        static string Name = "";

        public static string Find(string Make, string Model)
        {
            string ModelName = $"{Make} {Model}";

            SnipeItApi Snipe = Api.GetAPI();

            SearchFilter Search = new SearchFilter
            {
                Search = ModelName
            };

            try
            {
                Name = Snipe.ModelManager.FindOne(Search).Name;
                return Name;
            }
            catch (ArgumentOutOfRangeException)
            {
                string DeviceModel = Create(Make, Model, ModelName);
                Name = $"Created: {DeviceModel}";
                return Name;
            }
        }

        private static string Create(string DeviceMake, string DeviceModel, string ModelName)
        {
            SnipeItApi Snipe = Api.GetAPI();
            Model assetmodel = new Model
            {
                Name = ModelName,
                Manufacturer = Snipe.ManufacturerManager.Get(DeviceMake),
                Category = Snipe.CategoryManager.Get("Laptops"),
                ModelNumber = DeviceModel
            };
            Snipe.ModelManager.Create(assetmodel);
            Name = Snipe.ModelManager.Get(ModelName).Name;

            return Name;
        }
    }
}
