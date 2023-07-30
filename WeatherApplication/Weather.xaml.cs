using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WeatherApplicationLibrary;

namespace WeatherApplication
{
    /// <summary>
    /// Logika interakcji dla klasy Weather.xaml
    /// </summary>
    public partial class Weather : UserControl
    {
        public Weather()
        {
            InitializeComponent();
        }
        protected static UnpackLocationData cityCoords;
        private WeatherData getForecast(string input)
        {
            var address=input.Split(' ');
            //UnpackLocationData cityCoords;
            try
            {
                cityCoords = new UnpackLocationData(address[0], address[1]);
            }
            catch (IndexOutOfRangeException)
            {
                cityCoords = new UnpackLocationData(address[0]);
            }

            UnpackWeatherData forecast = new UnpackWeatherData(cityCoords.locationInfo.results[0].lon, cityCoords.locationInfo.results[0].lat);
            return forecast.weatherInfo;
        }
        private void updateUI()
        {
            WeatherData forecast = getForecast(searchBar.Text);
            actualForecast.Text = $"{searchBar.Text.Split(' ')[0]}, {DateTime.Now.ToUniversalTime().AddSeconds(cityCoords.locationInfo.results[0].timezone.offset_DST_seconds).ToString("HH:mm")}";
            tempBox.Text = forecast.hourly.temperature_2m[0].ToString();
            pressBox.Text = forecast.hourly.pressure_msl[0].ToString();
            windBox.Text = forecast.hourly.windspeed_10m[0].ToString();
            //windDirBox.Text = forecast.hourly.
            cloudsCoveBox.Text = forecast.hourly.cloudcover[0].ToString();
            //humBox.Text=forecast.hourly
            //rainProbabilityBox.Text=forecast.hourly
            sunRiseBox.Text = forecast.daily.sunrise[0].ToString();
            sunSetBox.Text = forecast.daily.sunset[0].ToString();
        }
        private void search_btn_Click(object sender, RoutedEventArgs e)
        {
            updateUI();
        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                updateUI();
            }
        }
    }
}
