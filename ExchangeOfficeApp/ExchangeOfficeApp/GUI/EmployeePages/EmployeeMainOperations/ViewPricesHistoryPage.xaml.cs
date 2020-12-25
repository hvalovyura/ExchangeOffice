using ExchangeOfficeApp.Repository;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for ViewPricesHistoryPage.xaml
    /// </summary>
    public partial class ViewPricesHistoryPage : Window
    {
        ReceiptRepoContext db;
        public ViewPricesHistoryPage()
        {
            InitializeComponent();

            db = new ReceiptRepoContext();
            db.ChangingPrices.Load();
            changingPricesList.ItemsSource = db.ChangingPrices.Local.ToBindingList();
        }
    }
}
