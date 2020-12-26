using ExchangeOfficeApp.EmployeePages;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services;
using ExchangeOfficeServices.Services.Interfaces;
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

namespace ExchangeOfficeApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly IUserService _userService;

        private string login;
        private string password;

        public LoginWindow()
        {
            InitializeComponent();

            _userService = new UserService();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login = this.loginInput.Text;
            password = this.passwordInput.Password;

            if(_userService.ValidateLogin(login, password))
            {
                EmployeePage employeePage = new EmployeePage();
                employeePage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Validation error", "Error", MessageBoxButton.OK);
            }
            
        }
    }
}
