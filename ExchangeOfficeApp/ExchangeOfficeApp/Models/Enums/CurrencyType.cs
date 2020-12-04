using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeApp.Enums
{
    public enum CurrencyType
    {
        [Description("Доллар США")] USD = 0,
        [Description("Евро")] EUR,
        [Description("Российский рубль")] RUB
    }
}
