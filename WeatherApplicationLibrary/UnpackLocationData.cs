using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeatherApplicationLibrary
{
    /// <summary>
    /// Zwraca zdeserializowany obiekt typu GetLocationData, który zawiera informacje o zadanej lokalizacji
    /// </summary>
    public class UnpackLocationData
    {
        public GetLocationData? locationInfo { get; init; }
        public UnpackLocationData(string city,string country)
        {
            GetJsonData data = new GetJsonData($"https://api.geoapify.com/v1/geocode/search?city={city}&country={country}&format=json&apiKey=800de78f48284bb6be82a82553423646");

            locationInfo = JsonSerializer.Deserialize<GetLocationData>(data.jsonStr);
        }
    }
}
