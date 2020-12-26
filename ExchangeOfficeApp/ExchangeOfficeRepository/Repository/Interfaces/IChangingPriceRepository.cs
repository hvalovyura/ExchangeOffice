using ExchangeOfficeApp.Enums;
using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository.Interfaces.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeRepository.Repository.Interfaces
{
    public interface IChangingPriceRepository : IRepository
    {
        public BindingList<ChangePrice> GetAllChangingPrices();
        public ChangePrice GetLastChangingPricesByCurrencyType(CurrencyType currencyType);
        public ChangePrice GetLastChangingPrices();
        public void Add(ChangePrice changePrice);
    }
}
