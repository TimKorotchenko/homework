using System;

namespace ConsoleApp10
{
    /*
    Создать класс CreditCard. 
        В классе создать два метода 
            Put - положить деньги на карту,
            Get - снять деньги с карты. 
        В классе создать элемент AccountAction. 
            Класс реализовать двумя способами: 
                1. когда AccountAction экземпляр делегата; 
                2. когда  AccountAction событие.

    Создать класс Client. 
    В классе создать метод, который будет использован для передачи в экземпляр делегат/ событие.

    MAIN
    +В методе main создать экземпляр класса CreditCard, создать экземпляр класса Client. 
    Client должен подписаться  на делегат/событие AccountAction экземпляра класса CreditCard. 
    Вызвать методы Put, Get, проанализировать результаты, сделать выводы. 

    + Доп
    +Добавить в делегат/событие AccountAction
        + анонимный метод,
        + лямбда-выражение.  
    Вызвать методы Put, Get, проанализировать результаты, сделать выводы.
        */

    internal class Program
    {
        static void Main(string[] args)
        {
            ViaDelegate();
            ViaEvent();

            Console.ReadKey();
        }

        private static void ViaDelegate()
        {
            Console.WriteLine("Через делегаты");

            var creditCard = new CreditCard_Delegate();

            // подписать метод, просто отдав какой-нибудь метод со схожей сигнатурой.
            var client = new Client();
            creditCard.SubscribeToMethod(client.PrintInfo);

            // тоже самое через лямбду
            creditCard.SubscribeToMethod(msg =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ResetColor();
            });

            // тоже самое через анонимный делегат / анонимный метод.
            creditCard.SubscribeToMethod(delegate (string msg)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                Console.ResetColor();
            });

            creditCard.Put();
            creditCard.Get();
        }

        private static void ViaEvent()
        {
            Console.WriteLine("Через события");
            
            var creditCard = new CreditCard_Event();

            // подписать метод, просто отдав какой-нибудь метод со схожей сигнатурой.
            var client = new Client();
            creditCard.Notify += client.PrintInfo;

            // тоже самое через лямбду
            creditCard.Notify += (msg =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(msg);
                Console.ResetColor();
            });

            // тоже самое через анонимный делегат / анонимный метод.
            creditCard.Notify += (delegate (string msg)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(msg);
                Console.ResetColor();
            });

            creditCard.Put();
            creditCard.Get();
        }
    }
}
