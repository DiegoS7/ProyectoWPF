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

namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to send your guide? \"NameGuide\"?", "Guide Of Somenthing", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Guide sent successfully!!", "Guide OfS");
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Well, you can edit more later.", "Guide OfS");
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to close the window ?","Guide Of Somenthing", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Oh come on!! :(", "Guide OfS");
                    this.Close();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Yes!, Continue please.", "Guide OfS");
                    break;
            }
           
        }
    }
}
