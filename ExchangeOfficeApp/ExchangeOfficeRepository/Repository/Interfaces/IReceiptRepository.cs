using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository.Interfaces.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeRepository.Repository.Interfaces
{
    public interface IReceiptRepository : IRepository
    {
        public BindingList<Receipt> GetAllReceipts();
        public Receipt GetLastChangingPrices();
        public void Add(Receipt receipt);
    }
}
