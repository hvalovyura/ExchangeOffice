using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ExchangeOfficeApp.Models.Enums
{
    public enum OperationType
    {
        [Description("Покупка")] BUY = 0,
        [Description("Продажа")] SELL
    }
}
