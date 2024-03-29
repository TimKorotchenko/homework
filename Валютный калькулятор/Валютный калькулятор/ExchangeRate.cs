﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Валютный_калькулятор
{
    public class ExchangeRate
    {
        public Currencies FirstCurrency { get; set; }
        public Currencies SecondCurrency { get; set; }
        public double Value { get; set; }
        public double CurrencyCount { get; set; }
        public override string ToString()
        {
            return $"{CurrencyCount} {FirstCurrency}={Value} {SecondCurrency}";
        }

       
        public ExchangeRate(Currencies firstCurrency, Currencies secondCurrency, double value)
        {
            FirstCurrency = firstCurrency;
            SecondCurrency = secondCurrency;
            Value = value;
        }
                   
        
        public void SetCount (double currencyCount)
        {
            CurrencyCount=currencyCount;
        }



    }
}
