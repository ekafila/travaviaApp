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

namespace InfoWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlyingManager fm = new FlyingManager();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickFind(object sender, RoutedEventArgs e)
        {

        }

        private void ShowOffers()
        {
            ListofBestOffers.ItemsSource = null;
            ListofBestOffers.ItemsSource =
        }
    }
}
