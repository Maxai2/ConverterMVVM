﻿using ConverterMVVM.ViewModel;
using CurrencyTextBoxControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ConverterMVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ConvertClass();
          
        }

        //private void tbValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        //{
        //    var textBox = sender as TextBox;
        //    e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        //}
    }
}
