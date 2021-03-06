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

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimerClass.counter = 0;
            TimerClass.timer.Interval = new TimeSpan(0, 0, 1);
            TimerClass.timer.Tick += Timer_Tick;
            TimerClass.timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Test.Content = TimerClass.counter;
            //TimerClass.UpdateCount();
        }


        private void ShowWindow1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
        }
    }
}
