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
        public BuySellPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
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
