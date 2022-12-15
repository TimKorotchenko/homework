using LinqKit;
using System.Linq;
using Валютный_калькулятор;

Console.WriteLine("Выберите валюту");
var exchangeRate1 = new ExchangeRate(Currencies.USD, Currencies.BYN, 2.55);
var exchangeRate2 = new ExchangeRate(Currencies.BYN, Currencies.USD, 0.39);
var exchangeRate3 = new ExchangeRate(Currencies.UK, Currencies.BYN, 3);
var exchangeRate4 = new ExchangeRate(Currencies.BYN, Currencies.UK, 0.33);
var exchangeRate5 = new ExchangeRate(Currencies.USD, Currencies.UK, 1.2);
var exchangeRate6 = new ExchangeRate(Currencies.UK, Currencies.USD, 0.83);

var currencyConverter = new CurrencyConverter();
currencyConverter.ExchangeRates.Add(exchangeRate1);
currencyConverter.ExchangeRates.Add(exchangeRate2);
currencyConverter.ExchangeRates.Add(exchangeRate3);
currencyConverter.ExchangeRates.Add(exchangeRate4);
currencyConverter.ExchangeRates.Add(exchangeRate5);
currencyConverter.AddExchangeRate(exchangeRate6);

foreach (var item in currencyConverter.ExchangeRates)
{
    Console.WriteLine(item.ToString());
    
}

Console.WriteLine("Начальная валюта");
string str1 = Console.ReadLine();
Enum.TryParse(str1, out Currencies originalCurrency);

Console.WriteLine("Конечная валюта");
string str2 = Console.ReadLine();
Enum.TryParse(str2, out Currencies lastCurrency);

Console.WriteLine("Сколько есть конечной валюты?");
string str3 = Console.ReadLine();
int b1 = Convert.ToInt32(str3);

var resault = currencyConverter.Convert(originalCurrency, lastCurrency, b1);
Console.WriteLine(resault.CurrencyCount);
Console.ReadLine();
