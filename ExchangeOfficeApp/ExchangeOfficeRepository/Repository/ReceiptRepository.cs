using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExchangeOfficeRepository.Repository
{
    class ReceiptRepository
    {
        private readonly ReceiptRepoContext _db;

        public ReceiptRepository()
        {
            _db = new ReceiptRepoContext();

            _db.Receipts.Load();
        }

        public BindingList<Receipt> GetAllReceipts()
        {
            return _db.Receipts.Any() ? _db.Receipts.Local.ToBindingList() : null;
        }

        public Receipt GetLastChangingPrices()
        {
            return _db.Receipts.Any() ? _db.Receipts.OrderBy(i => i.Id).Last() : null;
        }

        public void Add(Receipt receipt)
        {
            _db.Receipts.Add(receipt);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
