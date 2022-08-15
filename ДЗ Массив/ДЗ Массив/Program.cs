using System;

//Console.WriteLine("Задайте количество элементов массива");
//int elements = int.Parse(Console.ReadLine());
//int[] Array = new int[elements];
//Random rand = new Random();
//int MinValue = Array[0];
//int MaxValue = Array[0]; 
//Console.WriteLine("Вывод массива");
//for (int i = 0; i < Array.Length; i++)
//{
//    int value = rand.Next(-100, 100);
//    Array[i] = value;
//    Console.WriteLine(value);
//    if (Array[i] < MinValue)
//    {
//        MinValue = Array[i];

//    }
//    if (Array[i] > MaxValue)
//    {
//        MaxValue = Array[i];
//    }

//}
//Console.WriteLine("Наименьшее значение");
//Console.WriteLine(MinValue);
//Console.WriteLine("Наибольшее значение");
//Console.WriteLine(MaxValue);
//Console.WriteLine("Сумма всех элементов");
//Console.WriteLine(Array.Sum());
//Console.WriteLine("Среднее арифметическое всех элементов");
//Console.WriteLine(Array.Average());
//Console.WriteLine("Вывод в обратном порядке");
//for (int i = Array.Length-1; i >=0; i--)
//{
//    Console.WriteLine(Array[i]);
//}
//Console.WriteLine("Вывод двумерного массива");
//int[,] Array2 = new int[,]
//{
//    {1, 2, 3},
//    {4, 5, 6},
//    {7, 8, 9},
//    {10, 11, 12},
//};
//foreach (var item in Array2)
//{
//    Console.Write(item);
//}
//Вывод двумерного массива в обратном порядке не  смог реализовать.

Dictionary<string, string> translate = new Dictionary<string, string>()
{
    { "Black","Черный"},
    { "yellow", "Желтый"},
    { "blue", "Синий"},
    { "garden", "Сад"},
    { "milk", "Молоко"},
    { "mouse", "Мышь"},
    { "Forest", "Лес"},
    { "dog", "Пес"},
    { "cat", "Кошка"},
    { "Game", "Игра"},
    { "car", "Машина"},

};

Console.WriteLine("Введите слово на английском");
while (true)
    
{
    string word = Console.ReadLine().ToLower();
    if (translate.ContainsKey(word))
    {
        Console.WriteLine(translate[word]);
    }
    else Console.WriteLine("Такого слова нет в словаре ");
}










