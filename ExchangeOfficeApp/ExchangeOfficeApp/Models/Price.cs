using ExchangeOfficeApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeApp.Models
{
    public class Price
    {
        public int Id { get; set; }
        public CurrencyType CurrencyType { get; set; }
        public DateTime DateTime { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }

    }
}
