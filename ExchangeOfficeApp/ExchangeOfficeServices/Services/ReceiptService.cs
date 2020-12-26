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
    public class ReceiptService : IReceiptService
    {
        private readonly IReceiptRepository _repo;

        public ReceiptService()
        {
            _repo = new ReceiptRepository();
        }

        public void Add(Receipt receipt)
        {
            _repo.Add(receipt);
        }

        public BindingList<Receipt> GetAllReceipts()
        {
            return _repo.GetAllReceipts();
        }

        public Receipt GetLastChangingPrices()
        {
            return _repo.GetLastChangingPrices();
        }
    }
}
