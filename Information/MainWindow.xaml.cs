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
using Travavia.Model;

namespace Information
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlyingManager fm = new FlyingManager();
        
        public MainWindow()
        {
            InitializeComponent();            
            ShowBest();
        }
        private void ShowBest()
        {
            ListOfBest.ItemsSource = null;
            ListOfBest.ItemsSource = fm.Flights;
        }

        private void ButtonClickFind(object sender, RoutedEventArgs e)
        {
            SelectFlights();
        }

        private void SelectFlights()
        {
            foreach (var item in fm.Flights)
            {
                if ((item.DepAirport == textBoxDep.Text) && (item.ArrAirport == textBoxArr.Text) && (item.DepartureDT == datePickerDeparture.SelectedDate))
                {
                    if (comboCompany.SelectedItem.ToString() == item.Company)
                    {
                        var window = new found();
                        window.ShowDialog();
                    }
                }
            }
        }
    }
}
