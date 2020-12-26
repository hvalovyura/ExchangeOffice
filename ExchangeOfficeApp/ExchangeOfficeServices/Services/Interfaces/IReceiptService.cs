using ExchangeOfficeApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeServices.Services.Interfaces
{
    public interface IReceiptService
    {
        public void Add(Receipt receipt);
        public BindingList<Receipt> GetAllReceipts();
        public Receipt GetLastChangingPrices();
    }
}
