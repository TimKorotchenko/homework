namespace ДЗ_занятие_8
{
    public class HtmlParser : FileParser
    {
        public HtmlParser(string fn) :base(fn)
        {

        }

        public override string ParserFormat { get => ".html"; }

        public override void Analize()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {base.FileName}, был анализирован");
        }

        public override void Close()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {base.FileName}, был закрыт");
        }

        public override void Open()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {base.FileName}, был открыт");
        }

        public override void Parse()
        {
            base.Parse();
        }

        public override void Read()
        {
            Console.WriteLine($"{nameof(HtmlParser)}: Файл {base.FileName}, был прочитан");
        }
    }
}
