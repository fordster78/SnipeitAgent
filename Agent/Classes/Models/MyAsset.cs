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
    class MyAsset
    {
        static string Name = "";

        public static string Find(string DeviceName, string DeviceMake, string DeviceModel, string DeviceSerial)
        {
            string assetname = DeviceName;
            string Model = $"{DeviceMake} {DeviceModel}";
            SnipeItApi Snipe = Api.GetAPI();

            SearchFilter Search = new SearchFilter
            {
                Search = assetname
            };

            try
            {
                Name = Snipe.AssetManager.FindOne(Search).Name;
                return Name;
            }
            catch (ArgumentOutOfRangeException)
            {
                string asset = Create(assetname, Model, DeviceSerial, Search);
                Name = $"Created: {asset}";
                return Name;
            }
        }

        private static string Create(string assetname, string DeviceModel, string DeviceSerial, SearchFilter Search)
        {
            string comp = Api.GetCompany();
            string model = DeviceModel;

            SnipeItApi Snipe = Api.GetAPI();
            Asset newasset = new Asset
            {
                Company = Snipe.CompanyManager.Get(comp),
                AssetTag = "BGS00001",
                Model = Snipe.ModelManager.Get(model),
                StatusLabel = Snipe.StatusLabelManager.Get("Ready To Deploy"),
                Name = assetname,
                Serial = DeviceSerial,
                Notes = "Created by Agent"
            };

            Snipe.AssetManager.Create(newasset);
            Name = Snipe.AssetManager.FindOne(Search).Name;
            return Name;
        }

        public static Asset Data(string Name)
        {
            SnipeItApi Snipe = Api.GetAPI();

            SearchFilter Search = new SearchFilter
            {
                Search = Name
            };

            return Snipe.AssetManager.FindOne(Search);
        }
    }
}
