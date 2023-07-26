using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplicationLibrary
{
    public class GetJsonData
    {
        public string jsonStr { get; init; }
        public GetJsonData(string urlAdress)
        {
            using (WebClient client = new WebClient())
            {
                jsonStr = client.DownloadString(urlAdress);
            }
        }
    }
}
