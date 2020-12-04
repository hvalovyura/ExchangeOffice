using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeApp.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ClientMoney { get; set; }
        public double OfficeMoney { get; set; }
        public DateTime DateTime { get; set; }
    }
}
