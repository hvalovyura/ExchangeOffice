using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeApp.Models
{
    class Receipt
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ClientMoney { get; set; }
        public double OfficeMoney { get; set; }
        public DateTime DateTime { get; set; }
    }
}
