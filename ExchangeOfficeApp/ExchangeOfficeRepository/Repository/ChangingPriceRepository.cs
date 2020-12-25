using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeOfficeRepository.Repository
{
    public class ChangingPriceRepository : IChangingPriceRepository
    {
        private readonly AppDBContext _db;

        public ChangingPriceRepository()
        {
            _db = new AppDBContext();

            _db.ChangingPrices.Load();
        }

        public BindingList<ChangePrice> GetAllChangingPrices()
        {
            return _db.ChangingPrices.Any() ? _db.ChangingPrices.Local.ToBindingList() : null;
        }

        public ChangePrice GetLastChangingPrices()
        {
            return _db.ChangingPrices.Any() ? _db.ChangingPrices.OrderBy(i => i.Id).Last() : null;
        }

        public void Add(ChangePrice changePrice)
        {
            _db.ChangingPrices.Add(changePrice);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
