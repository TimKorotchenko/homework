using System;

namespace ConsoleApp10
{
    // через евент
    public class CreditCard_Event
    {
        public delegate void AccountAction(string msg);
        public event AccountAction Notify;

        public int money;

        public void Put()
        {
            Notify?.Invoke("Скок хочешь положить?:");
            var count = int.Parse(Console.ReadLine());
            
            money += count;

            Notify?.Invoke("Операция завершена");
            Notify?.Invoke($"Текущий баланс: {money}");
            Notify?.Invoke("");
        }

        public void Get()
        {
            Notify?.Invoke("Скок хочешь снять?:");
            var count = int.Parse(Console.ReadLine());

            money -= count;
            Notify?.Invoke("Операция завершена");
            Notify?.Invoke($"Текущий баланс: {money}");
            Notify?.Invoke("");
        }
    }
}
