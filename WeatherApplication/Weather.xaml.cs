﻿using System;
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

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
