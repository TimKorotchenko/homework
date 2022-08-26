namespace ДЗ_занятие_8
{
    public abstract class FileParser
    {
        public abstract void Read();
        public abstract void Open();
        public abstract void Analize();
        public abstract void Close();
        public virtual void Parse()
        {
            Open();
            Analize();
            Close();
        }

        public abstract string ParserFormat { get; }

        public string FileName { get; }

        public FileParser(string fileName)
        {
            FileName = fileName;
        }

        public static FileParser GetParser(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            FileParser fileParser;
            switch (extension)
            {
                case ".xml":
                    {
                        fileParser = new XmlParser(fileName);
                        break;
                    }
                case ".html":
                    {
                        fileParser = new HtmlParser(fileName);
                        break;
                    }
                case ".rft":
                    {
                        fileParser = new RtfParser(fileName);
                        break;
                    }
                default:
                    fileParser = null;
                    break;
            }

            return fileParser;
        }
    }
    
}

