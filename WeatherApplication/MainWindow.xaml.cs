﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WeatherApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CC.Content = new Weather();
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Weather();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Charts();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Info();
        }
    }
}
