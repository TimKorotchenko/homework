int a = 2;
int b = 3;

Console.WriteLine($"{a}-{b}");

(a, b) = (b, a);

Console.WriteLine($"{a}-{b}");