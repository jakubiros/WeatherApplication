using WeatherApplicationLibrary;

namespace WeatherApplicationUnitTests
{
    [TestClass]
    public class UnitTestWeatherLibrary
    {
        [DataTestMethod]
        [DataRow($"https://api.open-meteo.com/v1/forecast?latitude=50.25&longitude=21.75&hourly=temperature_2m,relativehumidity_2m,apparent_temperature,precipitation_probability,pressure_msl,cloudcover,visibility,windspeed_10m,winddirection_10m&daily=temperature_2m_max,temperature_2m_min,sunrise,sunset,uv_index_max,precipitation_sum,windspeed_10m_max,windgusts_10m_max&timezone=Europe%2FBerlin&forecast_days=3&models=best_match")]
        [DataRow($"https://api.geoapify.com/v1/geocode/search?city=Krakow&format=json&apiKey=800de78f48284bb6be82a82553423646")]
        [DataRow($"https://api.geoapify.com/v1/geocode/search?text=London%United%Kingdom&format=json&apiKey=800de78f48284bb6be82a82553423646")]
        public void DownloadJSONFromInternet(string url)
        {
            GetJsonData data = new GetJsonData(url);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void ListContainsProperHourlyAttributes()
        {
            WeatherData data = new UnpackWeatherData((float)21.1593832,(float)49.65829).weatherInfo;
            OneDayForecast oneDay = new OneDayForecast(data, 0);
            List<string> properHourlyAttributes = new List<string> {"time", "temperature_2m", "relativehumidity_2m", "apparent_temperature",
            "precipitation_probability", "pressure_msl", "cloudcover", "visibility", "windspeed_10m", "winddirection_10m"};
            Assert.AreEqual(properHourlyAttributes.Count,oneDay.hourlyAttributes.Count);
            
        }
    }

}