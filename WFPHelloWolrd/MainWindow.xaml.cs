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

namespace WFPHelloWolrd
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        private int aantalkliks = 0;
        private void MIjnKnop_Click(object sender, RoutedEventArgs e)
        {
            Labeltekst.Content = ("De wereldbol is een ruimteschip!");
            MijnLabelStatus.Background = Brushes.Red;
            MIjnKnop.Content = "klik hier" + "[" + (aantalkliks + 1) + "]";
            aantalkliks = aantalkliks + 1;
        }
    }
}
