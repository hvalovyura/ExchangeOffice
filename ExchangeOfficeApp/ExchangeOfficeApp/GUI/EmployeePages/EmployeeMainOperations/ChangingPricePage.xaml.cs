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

namespace ExchangeOfficeApp.EmployeePages.EmployeeMainOperations
{
    /// <summary>
    /// Interaction logic for ChangingPricePage.xaml
    /// </summary>
    public partial class ChangingPricePage : Window
    {
        private readonly IChangingPriceRepository _repo;
        public ChangingPricePage()
        {
            InitializeComponent();

            _repo = new ChangingPriceRepository();

            oldBuyPriceLabel.Content += _repo.GetLastChangingPrices().BuyPrice.ToString() + " BYN";
            oldSellPriceLabel.Content += _repo.GetLastChangingPrices().SellPrice.ToString() + " BYN";
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
            _repo.Add(newPrice);
            this.Close();
        }
    }
}
