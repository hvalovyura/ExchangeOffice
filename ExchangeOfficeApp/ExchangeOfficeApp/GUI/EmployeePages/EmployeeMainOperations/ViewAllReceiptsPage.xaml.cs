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
    /// Interaction logic for ViewAllReceiptsPage.xaml
    /// </summary>
    public partial class ViewAllReceiptsPage : Window
    {
        ReceiptContext db;
        public ViewAllReceiptsPage()
        {
            InitializeComponent();

            db = new ReceiptContext();

            receiptsList.ItemsSource = db.Receipts.Local.ToBindingList();
        }

        
    }
}
