using Intuit.Ipp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Валютный_калькулятор
{
    public class CurrencyConverter
    {
        public List<ExchangeRate> ExchangeRates { get; set; }
        public CurrencyConverter()
        {
            ExchangeRates = new List<ExchangeRate>();
        }
        public void AddExchangeRate(ExchangeRate exchangeRate)
        {
            ExchangeRates.Add(exchangeRate);
        }
        public void AddExchengeRates(ExchangeRate[] exchangeRates)
        {
            ExchangeRates.AddRange(exchangeRates);
        }
        public void TryDeleteExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            ExchangeRates.Remove(exchangeRate);
        }
            
    }
}
