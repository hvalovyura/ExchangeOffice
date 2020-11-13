using ExchangeOfficeApp.EmployeePages.EmployeeMainOperations;
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

namespace ExchangeOfficeApp.EmployeePages
{
    /// <summary>
    /// Interaction logic for EmployeePage.xaml
    /// </summary>
    public partial class EmployeePage : Window
    {
        public EmployeePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChangingPricePage changingPricePage = new ChangingPricePage();
            changingPricePage.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewPricesHistoryPage viewPricesHistoryPage = new ViewPricesHistoryPage();
            viewPricesHistoryPage.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewAllReceiptsPage viewAllReceiptsPage = new ViewAllReceiptsPage();
            viewAllReceiptsPage.Show();
        }
    }
}
