using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherApplicationLibrary
{
    /// <summary>
    /// Zwraca zdeserializowany obiekt typu WeatherData, który zawiera prognozę pogody wyszukanej po zadanej lokalizacji po przez współrzędne
    /// </summary>
    public class UnpackWeatherData
    {
        public WeatherData? weatherInfo { get; init; }
        public UnpackWeatherData(float lon, float lat)
        {
            GetJsonData data=new GetJsonData($"https://api.open-meteo.com/v1/forecast?latitude={lat.ToString().Replace(",", ".")}&longitude={lon.ToString().Replace(",", ".")}&hourly=temperature_2m,precipitation,pressure_msl,cloudcover,windspeed_10m&daily=temperature_2m_max,temperature_2m_min,sunrise,sunset&timezone=Europe%2FBerlin&forecast_days=3&models=best_match");

            weatherInfo= JsonSerializer.Deserialize<WeatherData>(data.jsonStr);
        }
    }
}
