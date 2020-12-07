using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Models.Enums;
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

namespace ExchangeOfficeApp
{
    /// <summary>
    /// Interaction logic for BuySellPage.xaml
    /// </summary>
    public partial class BuySellPage : Window
    {
        OperationType _type;
        private readonly ReceiptContext _context;
        public BuySellPage(OperationType type)
        {
            InitializeComponent();
            _type = type;
            _context = new ReceiptContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var receipt = new Receipt
            {
                FirstName = "FirstName",
                LastName = "LastName",
                OperationType = OperationType.BUY,
                ClientMoney = Convert.ToDouble(PriceInput.Text),
                OfficeMoney = Convert.ToDouble(CountInput.Text),
                DateTime = DateTime.Now,
                CurrencyType = CurrencyType.USD
            };

            _context.Receipts.Add(receipt);
            _context.SaveChanges();
            this.Close();
        }


        private void CountInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(this.CountInput.Text);
                this.PriceInput.Text = $"{count * 100}";
            }
            catch(Exception)
            {
                throw new NotImplementedException();
            }
        }
    }
}
