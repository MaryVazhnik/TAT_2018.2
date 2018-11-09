using System;

namespace Task_DEV_6
{
    class Program
    {
        private static void Main(string[] args)
        {
            Converter converter = new Converter();
            string[] sourceFile = args[0].Split('.');
            if (sourceFile[1] == "json")
            {
                Console.WriteLine(converter.ParseToXml(args[0]));
            }
            else if (sourceFile[1] == "xml")
            {
                Console.WriteLine(converter.ParseToJson(args[0]));
            }
        }
    }
}   