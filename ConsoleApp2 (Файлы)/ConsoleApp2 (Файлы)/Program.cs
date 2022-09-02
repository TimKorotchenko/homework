using System.IO;



string path = "D:\\TestFile.txt";
string text = "Тима учится работать с файлами";

using (StreamWriter writer = new StreamWriter(path, true))
{
     writer.WriteLineAsync("Тима учится работать с файлами");
}
