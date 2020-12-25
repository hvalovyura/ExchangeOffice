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
    /// Interaction logic for ViewAllReceiptsPage.xaml
    /// </summary>
    public partial class ViewAllReceiptsPage : Window
    {
        private readonly ReceiptRepoContext _context;
        public ViewAllReceiptsPage()
        {
            InitializeComponent();

            _context = new ReceiptRepoContext();

            _context.Receipts.Load();

            receiptsList.ItemsSource = _context.Receipts.Local.ToBindingList();
        }

        
    }
}
