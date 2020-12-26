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

            oldBuyPriceLabel.Content += _changingPriceService.GetLastChangingBuyPrice() + " BYN";
            oldSellPriceLabel.Content += _changingPriceService.GetLastChangingSellPrice() + " BYN";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var newBuyPrice = Convert.ToDouble(this.NewBuyPriceTextBox.Text);
            var newSellPrice = Convert.ToDouble(this.NewSellPriceTextBox.Text);
            var newPrice = new ChangePrice
            {
                CurrencyType = CurrencyType.USD,
                DateTime = DateTime.Now,
                BuyPrice = newBuyPrice,
                SellPrice = newSellPrice
            };
            _changingPriceService.Add(newPrice);
            this.Close();
        }
    }
}
