using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Models.Enums;
using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for BuySellPage.xaml
    /// </summary>
    public partial class BuySellPage : Window
    {
        OperationType _type;
        private readonly IChangingPriceRepository _changingPriceRepo;
        private readonly IReceiptRepository _receiptRepo;
        private readonly double buyPrice;
        private readonly double sellPrice;
        public BuySellPage(OperationType type)
        {
            InitializeComponent();

            _type = type;
            _changingPriceRepo = new ChangingPriceRepository();
            _receiptRepo = new ReceiptRepository();

            buyPrice = _changingPriceRepo.GetAllChangingPrices().OrderBy(p => p.DateTime).LastOrDefault().BuyPrice;
            sellPrice = _changingPriceRepo.GetAllChangingPrices().OrderBy(p => p.DateTime).LastOrDefault().SellPrice;

            this.MainLabel.Content = $"{type} page. Course: {(type == OperationType.BUY ? buyPrice : sellPrice)}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var receipt = new Receipt
            {
                FirstName = "FirstName",
                LastName = "LastName",
                OperationType = _type,
                ClientMoney = Convert.ToDouble(PriceInput.Text),
                OfficeMoney = Convert.ToDouble(CountInput.Text),
                DateTime = DateTime.Now,
                CurrencyType = CurrencyType.USD
            };

            _receiptRepo.Add(receipt);
            this.Close();
        }


        private void CountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(this.CountInput.Text);
                this.PriceInput.Text = $"{count * (_type == OperationType.BUY ? buyPrice : sellPrice)}";
            }
            catch(Exception)
            {
                this.PriceInput.Text = "0";
            }
        }
    }
}
