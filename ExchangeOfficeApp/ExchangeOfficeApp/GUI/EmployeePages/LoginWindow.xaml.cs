using ExchangeOfficeApp.EmployeePages;
using ExchangeOfficeApp.Repository;
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
        ReceiptContext _context;

        private string login;
        private string password;

        public LoginWindow()
        {
            InitializeComponent();

            _context = new ReceiptContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login = this.loginInput.Text;
            password = this.passwordInput.Text;

            if(_context.Users.Where(u => u.Username == login && u.Password == password).Any())
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
