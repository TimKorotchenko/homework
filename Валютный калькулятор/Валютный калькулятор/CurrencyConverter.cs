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
            var exchangeRate = FindExchangeRate(firstCurrency, secondCurrency);
            if (exchangeRate != null)
            {
                ExchangeRates.Remove(exchangeRate);
            }

        }
        public ExchangeRate FindExchangeRate(Currencies firstCurrency, Currencies secondCurrency)
        {
            var exchangeRate = ExchangeRates.FirstOrDefault(x => x.FirstCurrency == firstCurrency && x.SecondCurrency == secondCurrency);
            return exchangeRate;
        }
        public ExchangeRate Convert(Currencies firstCurrency, Currencies secondCurrency, int count)
        {
            var exchangeRate = FindExchangeRate(firstCurrency, secondCurrency);
            var m1 = new ExchangeRate(exchangeRate.FirstCurrency, exchangeRate.SecondCurrency,exchangeRate.Value);
            m1.SetCount(count/m1.Value);


            return m1;
            

        }

       
    }
}
