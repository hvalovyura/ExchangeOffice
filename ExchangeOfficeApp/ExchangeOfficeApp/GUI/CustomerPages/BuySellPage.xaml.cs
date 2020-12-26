using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Models.Enums;
using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services;
using ExchangeOfficeServices.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        private readonly IChangingPriceService _changingPriceService;
        private readonly IReceiptService _receiptService;
        private double buyPrice;
        private double sellPrice;
        private readonly int maxCountPerDay;
        private string _count;
        public BuySellPage(OperationType type)
        {
            InitializeComponent();

            _type = type;
            _changingPriceService = new ChangingPriceService();
            _receiptService = new ReceiptService();

            buyPrice = Convert.ToDouble(_changingPriceService.GetLastChangingBuyPriceByCurrencyType(CurrencyType.USD));
            sellPrice = Convert.ToDouble(_changingPriceService.GetLastChangingSellPriceByCurrencyType(CurrencyType.USD));
            maxCountPerDay = Convert.ToInt32(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).AppSettings.Settings["MaxCurrencyCountPerDay"].Value);

            CurrencyTypeComboBox.Items.Add(CurrencyType.EUR);
            CurrencyTypeComboBox.Items.Add(CurrencyType.USD);
            CurrencyTypeComboBox.Items.Add(CurrencyType.RUB);
            CurrencyTypeComboBox.SelectedItem = CurrencyType.USD;

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
                CurrencyType = (CurrencyType)CurrencyTypeComboBox.SelectedItem
            };

            _receiptService.Add(receipt);
            this.Close();
        }


        private void CountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(this.CountInput.Text);
                if (count <= maxCountPerDay)
                {
                    this.PriceInput.Text = $"{count * (_type == OperationType.BUY ? buyPrice : sellPrice)}";
                    _count = this.CountInput.Text;
                }
                else
                {
                    MessageBox.Show(this, $"Can't {_type} more than {maxCountPerDay}", "Error", MessageBoxButton.OK);
                    this.CountInput.Text = _count;
                }
                
            }
            catch(Exception)
            {
                this.PriceInput.Text = "0";
            }
        }

        private void CurrencyTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            buyPrice = Convert.ToDouble(_changingPriceService.GetLastChangingBuyPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem));
            sellPrice = Convert.ToDouble(_changingPriceService.GetLastChangingSellPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem));
            this.MainLabel.Content = $"{_type} page. Course: {(_type == OperationType.BUY ? buyPrice : sellPrice)}";
        }
    }
}
