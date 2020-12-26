using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services;
using ExchangeOfficeServices.Services.Interfaces;
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
        private readonly IChangingPriceService _changingPriceService;
        public ViewPricesHistoryPage()
        {
            InitializeComponent();

            _changingPriceService = new ChangingPriceService();
            changingPricesList.ItemsSource = _changingPriceService.GetAllChangingPrices();
        }
    }
}
