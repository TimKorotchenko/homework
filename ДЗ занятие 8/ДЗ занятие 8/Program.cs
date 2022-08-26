using ДЗ_занятие_8;

Console.WriteLine("Введи имя файла: [имя_файла].[формат]");

var fileName = Console.ReadLine();

var parser = FileParser.GetParser(fileName);

if(parser == null)
{
    Console.WriteLine("Неподдерживаемый формат");
    Environment.Exit(0);
}

parser.Parse();

Console.ReadKey();
