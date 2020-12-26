using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeServices.Services
{
    public class ChangingPriceService : IChangingPriceService
    {
        private readonly IChangingPriceRepository _repo;

        public ChangingPriceService()
        {
            _repo = new ChangingPriceRepository();
        }

        public string GetLastChangingBuyPrice()
        {
            return _repo.GetLastChangingPrices().BuyPrice.ToString();
        }

        public string GetLastChangingSellPrice()
        {
            return _repo.GetLastChangingPrices().SellPrice.ToString();
        }
        public void Add(ChangePrice changePrice)
        {
            _repo.Add(changePrice);
        }

        public BindingList<ChangePrice> GetAllChangingPrices()
        {
            return _repo.GetAllChangingPrices();
        }
    }
}
