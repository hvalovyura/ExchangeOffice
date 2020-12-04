using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Repository;
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

namespace ExchangeOfficeApp.EmployeePages.EmployeeMainOperations
{
    /// <summary>
    /// Interaction logic for ChangingPricePage.xaml
    /// </summary>
    public partial class ChangingPricePage : Window
    {
        private readonly ReceiptContext _receiptContext;
        public ChangingPricePage()
        {
            InitializeComponent();
            _receiptContext = new ReceiptContext();
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
            _receiptContext.ChangingPrices.Add(newPrice);
            _receiptContext.SaveChanges();
            this.Close();
        }
    }
}
