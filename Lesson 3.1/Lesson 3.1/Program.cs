while (true)
{
    Console.WriteLine("Введите два целых числа");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a > b)
    {
        Console.WriteLine("Первое число больше");
    }
    if (a == b)
    {
        Console.WriteLine("Числа равны");
    }
    if (a < b)
    {
        Console.WriteLine("Второе число больше");
    }
}


