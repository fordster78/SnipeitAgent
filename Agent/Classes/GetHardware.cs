using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Agent.Classes
{
    class GetHardware
    {
        private static string querysystem(string query)
        {
            var procStartInfo = new ProcessStartInfo("cmd", "/c " + "wmic csproduct get " + query)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            var proc = new Process() { StartInfo = procStartInfo };
            proc.Start();

            return proc.StandardOutput.ReadToEnd().Replace(query, string.Empty).Trim().ToUpper();
        }

        public static string ComputerName()
        {
            string name = System.Environment.MachineName;

            return name;
        }

        public static string SerialNumber()
        {
            string serial = querysystem("IdentifyingNumber");

            return serial;
        }


        public static string ComputerMake()
        {
            string make = querysystem("Vendor");

            return make;
        }

        public static string ComputerModel()
        {
            string model = querysystem("Name");

            return model;
        }
    }
}
