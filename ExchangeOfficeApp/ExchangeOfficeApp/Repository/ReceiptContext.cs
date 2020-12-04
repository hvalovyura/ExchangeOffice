using ExchangeOfficeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeApp.Repository
{
    public class ReceiptContext: DbContext
    {

        public DbSet<Receipt> Receipts { get; set; }

        public ReceiptContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
