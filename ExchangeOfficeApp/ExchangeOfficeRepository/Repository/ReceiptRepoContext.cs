using ExchangeOfficeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeOfficeApp.Repository
{
    public class ReceiptRepoContext: DbContext
    {

        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ChangePrice> ChangingPrices { get; set; }
        public DbSet<User> Users { get; set; }

        public ReceiptRepoContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ExchangeOfficeDb;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
