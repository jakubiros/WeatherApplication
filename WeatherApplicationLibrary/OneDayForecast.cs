using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplicationLibrary
{
    public class OneDayForecast
    {
        private WeatherData data;
        private int numOfDays => data.hourly.time.Length/24;
        public Dictionary<TimeOnly,Dictionary<List<string>,Array>> hourlyDayForecast { get; private set; }
        private List<string> hourlyAttributes = new List<string>();

        public OneDayForecast(WeatherData forecast, int dayOfForecast)
        {
            data= forecast;

            foreach (var name in data.hourly.GetType().GetProperties())
            {
                hourlyAttributes.Add(name.ToString().Split(" ")[1]);
            }
            //foreach (var dict in )

            int startInd =0;
            int endInd = startInd + 23;
            if (dayOfForecast == 0) startInd = 0;
            else if (dayOfForecast == 1) startInd = 23;
            else if (dayOfForecast == 2) startInd = 47;

            string[] time = data.hourly.time;
            float[] temperature_2m = data.hourly.temperature_2m;
            int[] relativehumidity_2m = data.hourly.relativehumidity_2m;
            float[] apparent_temperature = data.hourly.apparent_temperature;
            int[] precipitation_probability = data.hourly.precipitation_probability;
            float[] pressure_msl = data.hourly.pressure_msl;
            int[] cloudcover = data.hourly.cloudcover;
            float[] visibility = data.hourly.visibility;
            float[] windspeed_10m = data.hourly.windspeed_10m;
            int[] winddirection_10m = data.hourly.winddirection_10m;

            while (startInd == endInd)
            {

                //hourlyDayForecast.Add(new Dictionary<TimeOnly, Dictionary<List<string>, Array>>(TimeOnly.Parse(data.hourly.time[startInd].Split("T")[1],
                //    new Dictionary<List<string>, Array>(hourlyAttributes, ))
                
            }
        }
    }
}
