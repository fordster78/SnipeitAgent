using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnipeSharp;
using SnipeSharp.Endpoints.Models;

namespace Agent.Classes
{
    class Snipeit
    {
        public static void SendTo(String DeviceName, String DeviceSerial, String DeviceTag)
        {
            SnipeItApi Snipe = new SnipeItApi();
            Snipe.ApiSettings.ApiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjUyMDcwNTgzZWJiYjlmYmViYmYyZjk0N2M2NmU4NTIxZjk2MmYyNmM2MjY3MWM0ZjAyZjc1Y2MyMmViNjRkYTdhYTYzMmY2ZTVmNjlhNTQzIn0.eyJhdWQiOiIxIiwianRpIjoiNTIwNzA1ODNlYmJiOWZiZWJiZjJmOTQ3YzY2ZTg1MjFmOTYyZjI2YzYyNjcxYzRmMDJmNzVjYzIyZWI2NGRhN2FhNjMyZjZlNWY2OWE1NDMiLCJpYXQiOjE1MTM2MzEzNzcsIm5iZiI6MTUxMzYzMTM3NywiZXhwIjoxNTQ1MTY3Mzc3LCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.BiNDcUi-Oo-NFLCu6iSWd1-_4cf8tpaP42xxIiZJFlMwSpZX2Q6IqasD5KGY1gof178xiczahh16dDHjrYSMGTtj6F1MRS1BiU58InG-A04-g0reoywJtspMUqP5NIyT4yx-GUy3A419Nk8BTPXQ6N9rdkoxiNgZbY44V7JTxHrJU0qO0ZB-Hno-_EA4Io75hVEBei3YNAm--BLHsoEBFx9eYKbUugxk0PIfu_6341wxOnxAYyp8JVDwe_YnkWZj981qpk2EKwpiATZru14io9tFONyK5rs_-iq9tKNAYatA-uMmubUfzrYTyTXbskCKB9wU4PsJXFoQD2orPk3JbOKj_DUb3s0qC3ryoqi5kkUlsDnNvI7l5c8fz-lMQwA6_URQIkaYtHzScxBFqRAzdH9x9ShSJJ9pvnzytI85miQA8IcY-bPFGMd5dm0wICKecbt58RoCUAebZqmBTuS-xZCClH34MB7-NtmDo6RFAryHCO9gGb9yAv2TQpPfwNvR1w32s2-HssAhwlSWjfIKG4KI1TiSFrYOF1jSE8oCFx4FdIaBzndXoQ2S3OpJxN638rBrpIEYWfHlqnH7pzUTqVh3BkDFfox070TwgXfjHN_xjDyFqYIJhCivg64tf67wIcv1JbdFsV2kHzGcVx-frWFuRP23lRvHtycHkAGy2C0";
            Snipe.ApiSettings.BaseUrl = new Uri("http://localhost/api/v1");

            Asset asset = new Asset()
            {
                Name = DeviceName,
                AssetTag = DeviceTag,
                Serial = DeviceSerial,
                Model = Snipe.ModelManager.Get("Test Model"),
                StatusLabel = Snipe.StatusLabelManager.Get(1),
                Notes = "Created By Agent"
            };

            Snipe.AssetManager.Create(asset);
            Console.WriteLine("Upload completed.");
            System.Windows.Forms.MessageBox.Show("Details have now been uploaded.", "Upload Complete");
        }

        public static void GetInfo()
        {
            SnipeItApi Snipe = new SnipeItApi();
            Snipe.ApiSettings.ApiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjUyMDcwNTgzZWJiYjlmYmViYmYyZjk0N2M2NmU4NTIxZjk2MmYyNmM2MjY3MWM0ZjAyZjc1Y2MyMmViNjRkYTdhYTYzMmY2ZTVmNjlhNTQzIn0.eyJhdWQiOiIxIiwianRpIjoiNTIwNzA1ODNlYmJiOWZiZWJiZjJmOTQ3YzY2ZTg1MjFmOTYyZjI2YzYyNjcxYzRmMDJmNzVjYzIyZWI2NGRhN2FhNjMyZjZlNWY2OWE1NDMiLCJpYXQiOjE1MTM2MzEzNzcsIm5iZiI6MTUxMzYzMTM3NywiZXhwIjoxNTQ1MTY3Mzc3LCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.BiNDcUi-Oo-NFLCu6iSWd1-_4cf8tpaP42xxIiZJFlMwSpZX2Q6IqasD5KGY1gof178xiczahh16dDHjrYSMGTtj6F1MRS1BiU58InG-A04-g0reoywJtspMUqP5NIyT4yx-GUy3A419Nk8BTPXQ6N9rdkoxiNgZbY44V7JTxHrJU0qO0ZB-Hno-_EA4Io75hVEBei3YNAm--BLHsoEBFx9eYKbUugxk0PIfu_6341wxOnxAYyp8JVDwe_YnkWZj981qpk2EKwpiATZru14io9tFONyK5rs_-iq9tKNAYatA-uMmubUfzrYTyTXbskCKB9wU4PsJXFoQD2orPk3JbOKj_DUb3s0qC3ryoqi5kkUlsDnNvI7l5c8fz-lMQwA6_URQIkaYtHzScxBFqRAzdH9x9ShSJJ9pvnzytI85miQA8IcY-bPFGMd5dm0wICKecbt58RoCUAebZqmBTuS-xZCClH34MB7-NtmDo6RFAryHCO9gGb9yAv2TQpPfwNvR1w32s2-HssAhwlSWjfIKG4KI1TiSFrYOF1jSE8oCFx4FdIaBzndXoQ2S3OpJxN638rBrpIEYWfHlqnH7pzUTqVh3BkDFfox070TwgXfjHN_xjDyFqYIJhCivg64tf67wIcv1JbdFsV2kHzGcVx-frWFuRP23lRvHtycHkAGy2C0";
            Snipe.ApiSettings.BaseUrl = new Uri("http://localhost/api/v1");
            Asset asset = Snipe.AssetManager.Get(8);
            System.Windows.Forms.MessageBox.Show(
                "Serial: " + asset.Serial + "\n" +
                "Asset Tag: " + asset.AssetTag + "\n" +
                "Notes: " + asset.Notes, "Details: " + asset.Name);

        }

        public static void UpdateInfo(String DeviceName, String DeviceSerial, String DeviceTag)
        {
            SnipeItApi Snipe = new SnipeItApi();
            Snipe.ApiSettings.ApiToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsImp0aSI6IjUyMDcwNTgzZWJiYjlmYmViYmYyZjk0N2M2NmU4NTIxZjk2MmYyNmM2MjY3MWM0ZjAyZjc1Y2MyMmViNjRkYTdhYTYzMmY2ZTVmNjlhNTQzIn0.eyJhdWQiOiIxIiwianRpIjoiNTIwNzA1ODNlYmJiOWZiZWJiZjJmOTQ3YzY2ZTg1MjFmOTYyZjI2YzYyNjcxYzRmMDJmNzVjYzIyZWI2NGRhN2FhNjMyZjZlNWY2OWE1NDMiLCJpYXQiOjE1MTM2MzEzNzcsIm5iZiI6MTUxMzYzMTM3NywiZXhwIjoxNTQ1MTY3Mzc3LCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.BiNDcUi-Oo-NFLCu6iSWd1-_4cf8tpaP42xxIiZJFlMwSpZX2Q6IqasD5KGY1gof178xiczahh16dDHjrYSMGTtj6F1MRS1BiU58InG-A04-g0reoywJtspMUqP5NIyT4yx-GUy3A419Nk8BTPXQ6N9rdkoxiNgZbY44V7JTxHrJU0qO0ZB-Hno-_EA4Io75hVEBei3YNAm--BLHsoEBFx9eYKbUugxk0PIfu_6341wxOnxAYyp8JVDwe_YnkWZj981qpk2EKwpiATZru14io9tFONyK5rs_-iq9tKNAYatA-uMmubUfzrYTyTXbskCKB9wU4PsJXFoQD2orPk3JbOKj_DUb3s0qC3ryoqi5kkUlsDnNvI7l5c8fz-lMQwA6_URQIkaYtHzScxBFqRAzdH9x9ShSJJ9pvnzytI85miQA8IcY-bPFGMd5dm0wICKecbt58RoCUAebZqmBTuS-xZCClH34MB7-NtmDo6RFAryHCO9gGb9yAv2TQpPfwNvR1w32s2-HssAhwlSWjfIKG4KI1TiSFrYOF1jSE8oCFx4FdIaBzndXoQ2S3OpJxN638rBrpIEYWfHlqnH7pzUTqVh3BkDFfox070TwgXfjHN_xjDyFqYIJhCivg64tf67wIcv1JbdFsV2kHzGcVx-frWFuRP23lRvHtycHkAGy2C0";
            Snipe.ApiSettings.BaseUrl = new Uri("http://localhost/api/v1");


            Asset asset = Snipe.AssetManager.Get(1375);
            asset.AssetTag = DeviceTag;
            Snipe.AssetManager.Update(asset);
            Console.WriteLine("Update complete.");
            System.Windows.Forms.MessageBox.Show("Details have now been updated.", "Update Complete");

        }
    }
}
