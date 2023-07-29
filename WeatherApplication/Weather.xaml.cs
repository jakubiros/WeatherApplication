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
        private WeatherData getForecast(string input)
        {
            var address=input.Split(' ');
            UnpackLocationData cityCoords;
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
        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                WeatherData forecast = getForecast(searchBar.Text);
                actualForecast.Text = searchBar.Text.Split(' ')[0];
            }
        }
    }
}
