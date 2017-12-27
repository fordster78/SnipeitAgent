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
    class MyCategory
    {
        static string Name = "";

        public static string Find()
        {
            string Category = Api.GetCategory();
        
            SnipeItApi Snipe = Api.GetAPI();

            SearchFilter Search = new SearchFilter
            {
                Search = Category
            };

            try
            {
                Name = Snipe.CategoryManager.FindOne(Search).Name;
                return Name;
            }
            catch (ArgumentOutOfRangeException)
            {
                Create(Category);
                Name = $"Created: {Category}";
                return Name;
            }
        }

        private static string Create(string DeviceCategory)
        {
            string category = DeviceCategory;
            
            SnipeItApi Snipe = Api.GetAPI();
            
                Category Cat = new Category
                {
                    Name = category,
                    Type = "asset"
                };
            Snipe.CategoryManager.Create(Cat);
            Name = Snipe.CategoryManager.Get(category).Name;
            return Name;

        }
    }
}
