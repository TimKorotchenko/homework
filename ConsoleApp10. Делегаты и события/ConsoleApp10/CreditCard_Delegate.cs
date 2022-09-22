using System;

namespace ConsoleApp10
{
    // через делегат
    public class CreditCard_Delegate
    {
        public delegate void AccountAction(string msg);
        private AccountAction taken;

        public int money;

        public void SubscribeToMethod(AccountAction accountAction)
        {
            taken += accountAction;
        }

        public void Put()
        {
            taken.Invoke("Скок хочешь положить?:");
            var count = int.Parse(Console.ReadLine());
            
            money += count;
            
            taken.Invoke("Операция завершена");
            taken.Invoke($"Текущий баланс: {money}");
            taken.Invoke("");
        }

        public void Get()
        {
            taken.Invoke("Скок хочешь снять?:");
            var count = int.Parse(Console.ReadLine());

            money -= count;
            taken.Invoke("Операция завершена");
            taken.Invoke($"Текущий баланс: {money}");
            taken.Invoke("");
        }
    }
}
