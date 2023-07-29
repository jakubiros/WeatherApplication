using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplicationLibrary
{
    public class GetLocationData
    {
        public Result[] results { get; set; }
        public class Result
        {
            public Datasource datasource { get; set; }
            public string country { get; set; }
            public string country_code { get; set; }
            public string state { get; set; }
            public string county { get; set; }
            public string city { get; set; }
            public float lon { get; set; }
            public float lat { get; set; }
            public string formatted { get; set; }
            public string address_line1 { get; set; }
            public string address_line2 { get; set; }
            public string category { get; set; }
            public string result_type { get; set; }
            public Timezone timezone { get; set; }
        }
        public class Datasource
        {
            public string sourcename { get; set; }
            public string attribution { get; set; }
            public string license { get; set; }
            public string url { get; set; }
        }
        public class Timezone
        {
            public string name { get; set; }
            public string offset_STD { get; set; }
            public int offset_STD_seconds { get; set; }
            public string offset_DST { get; set; }
            public int offset_DST_seconds { get; set; }
            public string abbreviation_STD { get; set; }
            public string abbreviation_DST { get; set; }
        }

    }
}
