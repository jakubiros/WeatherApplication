using System;
using System.Collections;
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
        private List<Dictionary<string,List<Dictionary<string, string>>>> hourlyDayForecastList = new List<Dictionary<string,List<Dictionary<string, string>>>>();
        //public Dictionary<TimeOnly,Dictionary<List<string>,Array>> hourlyDayForecast { get; private set; }
        public List<string> hourlyAttributes = new List<string>();
        private List<string[]> forecastValues = new List<string[]>();

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
            string[] temperature_2m = data.hourly.temperature_2m.Select(x=>x.ToString()).ToArray();
            string[] relativehumidity_2m = data.hourly.relativehumidity_2m.Select(x => x.ToString()).ToArray();
            string[] apparent_temperature = data.hourly.apparent_temperature.Select(x => x.ToString()).ToArray();
            string[] precipitation_probability = data.hourly.precipitation_probability.Select(x => x.ToString()).ToArray();
            string[] pressure_msl = data.hourly.pressure_msl.Select(x => x.ToString()).ToArray();
            string[] cloudcover = data.hourly.cloudcover.Select(x => x.ToString()).ToArray();
            string[] visibility = data.hourly.visibility.Select(x => x.ToString()).ToArray();
            string[] windspeed_10m = data.hourly.windspeed_10m.Select(x => x.ToString()).ToArray();
            string[] winddirection_10m = data.hourly.winddirection_10m.Select(x => x.ToString()).ToArray(); 

            forecastValues.Add(temperature_2m);
            forecastValues.Add(relativehumidity_2m);
            forecastValues.Add(apparent_temperature);
            forecastValues.Add(precipitation_probability);
            forecastValues.Add(pressure_msl);
            forecastValues.Add(cloudcover);
            forecastValues.Add(visibility);
            forecastValues.Add(windspeed_10m);
            forecastValues.Add(winddirection_10m);

            while (startInd == endInd)
            {
                List<Dictionary<string,string>> dictList= new List<Dictionary<string,string>>();
                for (int i =0; i<forecastValues.Count; i++)
                {
                    var d= new Dictionary<string,string>();
                    var temp = forecastValues[i];
                    //hourlyAttr zawiera time czyli 1 elem więcej niż temp, usunąc
                    d.Add(hourlyAttributes[i], temp[startInd]);
                    dictList.Add(d);
                }
                var tempDict = new Dictionary<string, List<Dictionary<string, string>>>();
                tempDict.Add(time[startInd].Split("T")[1], dictList);
                hourlyDayForecastList.Add(tempDict);
                
            }
        }
    }
}
