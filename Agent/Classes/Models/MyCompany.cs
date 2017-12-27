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
    class MyCompany
    {
        static string Name = "";

        public static string Find()
        {
            string companyname = Api.GetCompany();

            SnipeItApi Snipe = Api.GetAPI();
            SearchFilter Search = new SearchFilter
            {
                Search = companyname
            };

            try
            {
                Name = Snipe.CompanyManager.FindOne(Search).Name;
                return Name;
            }
            catch(ArgumentOutOfRangeException)
            {
                string asset = Create(companyname);
                Name = $"Created: {asset}";
                return Name;
            }
        }

        private static string Create(string companyname)
        {
            SnipeItApi Snipe = Api.GetAPI();
            Company Comp = new Company
            {
                Name = companyname,
            };

            Snipe.CompanyManager.Create(Comp);
            Name = Snipe.CompanyManager.Get(companyname).Name;
            return Name;
        }
    }
}
