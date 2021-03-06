﻿using ExchangeOfficeApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExchangeOfficeApp
{
    /// <summary>
    /// Interaction logic for CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Window
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {
            BuySellPage buySellPage = new BuySellPage(OperationType.BUY);
            buySellPage.Show();
        }

        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            BuySellPage buySellPage = new BuySellPage(OperationType.SELL);
            buySellPage.Show();
        }
    }
}
