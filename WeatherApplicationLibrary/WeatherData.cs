﻿namespace WeatherApplicationLibrary
{
    public class WeatherData
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public float elevation { get; set; }
        public Hourly_Units hourly_units { get; set; }
        public Hourly hourly { get; set; }
        public Daily_Units daily_units { get; set; }
        public Daily daily { get; set; }
        public class Hourly_Units
        {
            public string time { get; set; }
            public string temperature_2m { get; set; }
            public string precipitation { get; set; }
            public string pressure_msl { get; set; }
            public string cloudcover { get; set; }
            public string windspeed_10m { get; set; }
        }
        public class Hourly
        {
            public string[] time { get; set; }
            public float[] temperature_2m { get; set; }
            public float[] precipitation { get; set; }
            public float[] pressure_msl { get; set; }
            public int[] cloudcover { get; set; }
            public float[] windspeed_10m { get; set; }
        }
        public class Daily_Units
        {
            public string time { get; set; }
            public string temperature_2m_max { get; set; }
            public string temperature_2m_min { get; set; }
            public string sunrise { get; set; }
            public string sunset { get; set; }
        }
        public class Daily
        {
            public string[] time { get; set; }
            public float[] temperature_2m_max { get; set; }
            public float[] temperature_2m_min { get; set; }
            public string[] sunrise { get; set; }
            public string[] sunset { get; set; }
        }
    }
}