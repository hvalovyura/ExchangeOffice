using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeServices.Services.Interfaces
{
    public interface IChangingPriceService
    {
        public string GetLastChangingBuyPrice();
        public string GetLastChangingSellPrice();
        public string GetLastChangingSellPriceByCurrencyType(CurrencyType currencyType);
        public string GetLastChangingBuyPriceByCurrencyType(CurrencyType currencyType);
        public BindingList<ChangePrice> GetAllChangingPrices();
        public void Add(ChangePrice changePrice);
    }
}
