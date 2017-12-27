using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agent.Classes.Models;
using Agent.Classes.Queries;
using SnipeSharp.Endpoints.Models;

namespace Agent.Classes
{
    class Main
    {
        
        public static void UploadData()
        {
            MyCompany.Find();
            MyCategory.Find();
            MyManufacturer.Find(Hardware.ComputerMake());
            MyAssetModel.Find(Hardware.ComputerMake(), Hardware.ComputerModel());

            MyAsset.Find(Hardware.ComputerName(), Hardware.ComputerMake(), Hardware.ComputerModel(), Hardware.SerialNumber());
            
        }

        public static Asset GetData()
        {
            string device = Hardware.ComputerName();
            return MyAsset.Data(device);
            
        }
    }
}
