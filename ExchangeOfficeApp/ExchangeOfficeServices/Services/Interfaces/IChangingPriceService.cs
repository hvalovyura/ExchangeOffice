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
        public BindingList<ChangePrice> GetAllChangingPrices();
        public void Add(ChangePrice changePrice);
    }
}
