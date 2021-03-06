﻿using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Repository;
using ExchangeOfficeServices.Services;
using ExchangeOfficeServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExchangeOfficeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserService _userService;
        public MainWindow()
        {
            InitializeComponent();

            _userService = new UserService();
            if (!_userService.GetAllUsers().Any())
            {
                _userService.Add("admin", "admin");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerPage customerPage = new CustomerPage();
            customerPage.Show();
        }
    }
}
