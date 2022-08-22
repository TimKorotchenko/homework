using System;
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
        public int CurrencyCount { get; set; }
        public override string ToString()
        {
            return $"{CurrencyCount} {FirstCurrency}={Value} {SecondCurrency}";
        }

        public ExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            FirstCurrency = firstCurrency;
            SecondCurrency = secondCurrency;

        }

        public ExchangeRate(Currencies firstCurrency, Currencies secondCurrency, double value)
        {
            FirstCurrency = firstCurrency;
            SecondCurrency = secondCurrency;
            Value = value;
        }

        internal static object FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        public void SetValue(double value)
        {

         Value=value;

        }
        public void SetCount (int currencyCount)
        {
            CurrencyCount=currencyCount;
        }



    }
}
