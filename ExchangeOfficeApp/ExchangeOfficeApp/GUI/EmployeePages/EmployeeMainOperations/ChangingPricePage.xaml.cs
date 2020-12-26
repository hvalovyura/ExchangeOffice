using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
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
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces.General;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services.Interfaces;
using ExchangeOfficeServices.Services;

namespace ExchangeOfficeApp.EmployeePages.EmployeeMainOperations
{
    /// <summary>
    /// Interaction logic for ChangingPricePage.xaml
    /// </summary>
    public partial class ChangingPricePage : Window
    {
        private readonly IChangingPriceService _changingPriceService;
        public ChangingPricePage()
        {
            InitializeComponent();

            _changingPriceService = new ChangingPriceService();

            CurrencyTypeComboBox.Items.Add(CurrencyType.EUR);
            CurrencyTypeComboBox.Items.Add(CurrencyType.USD);
            CurrencyTypeComboBox.Items.Add(CurrencyType.RUB);
            CurrencyTypeComboBox.SelectedItem = CurrencyType.USD;

            oldBuyPriceLabel.Content = "Old buy price: " + _changingPriceService.GetLastChangingBuyPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem) + " BYN";
            oldSellPriceLabel.Content = "Old sell price: " + _changingPriceService.GetLastChangingSellPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem) + " BYN";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newBuyPrice = Convert.ToDouble(this.NewBuyPriceTextBox.Text);
            var newSellPrice = Convert.ToDouble(this.NewSellPriceTextBox.Text);
            var newPrice = new ChangePrice
            {
                CurrencyType = (CurrencyType)CurrencyTypeComboBox.SelectedItem,
                DateTime = DateTime.Now,
                BuyPrice = newBuyPrice,
                SellPrice = newSellPrice
            };
            _changingPriceService.Add(newPrice);
            this.Close();
        }

        private void CurrencyTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            oldBuyPriceLabel.Content = "Old buy price: " +  _changingPriceService.GetLastChangingBuyPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem) + " BYN";
            oldSellPriceLabel.Content = "Old sell price: " + _changingPriceService.GetLastChangingSellPriceByCurrencyType((CurrencyType)CurrencyTypeComboBox.SelectedItem) + " BYN";
        }
    }
}
