using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
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
        private readonly IChangingPriceRepository _repo;
        public ViewPricesHistoryPage()
        {
            InitializeComponent();

            _repo = new ChangingPriceRepository();
            changingPricesList.ItemsSource = _repo.GetAllChangingPrices();
        }
    }
}
