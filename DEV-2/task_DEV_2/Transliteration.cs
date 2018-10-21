using System;
using System.Text;

namespace task_DEV_2
{
    public class Transliteration
    {
        const int CountOfChars = 33;
        string[] russian = {"А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н",
                          "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", 
                          "Э", "Ю", "Я"};
        string[] translitForRussian = {"A", "B", "V", "G", "D", "E", "YO", "ZH", "Z", "I", "Y", "K", "L", "M", "N",
                          "O", "P", "R", "S", "T", "U", "F", "KH", "TS", "CH", "SH", "SCH", "", "Y", "",
                          "E", "YU", "YA"};
        /// <summary>
        /// A method that converts an input string to an array of characters
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Converted source string</returns>
        public char[] StringPreparing(string[] args)
        {
            StringBuilder stringBuilderSourceString = new StringBuilder();
            for (int i = 0; i < args.Length; i++)
            {
                if (i == args.Length - 1)
                {
                    stringBuilderSourceString.Append(args[i]);
                }
                else
                {
                    stringBuilderSourceString.Append(args[i]).Append(" ");
                }
            }
            string sourceString = stringBuilderSourceString.ToString().ToUpper();
            if (sourceString == String.Empty)
            {
                throw new Exception("String is empty, try again.");
            }
            char[] sourceCharArray = sourceString.ToCharArray();
            return sourceCharArray;
        }
        /// <summary>
        /// Translet from Russian to translit and conversely
        /// </summary>
        /// <param name="sourceCharArray"></param>
        /// <returns>Translated source string</returns>
        public String Translate(char[] sourceCharArray)
        {
            StringBuilder stringBuilderForOutput = new StringBuilder();
            for (int i = 0; i < sourceCharArray.Length; i++)
            {
                bool status = false;
                for (int j = 0; j < CountOfChars; j++)
                {
                    String character = sourceCharArray[i].ToString();

                    if (character == russian[j])
                    {
                        stringBuilderForOutput.Append(translitForRussian[j]);
                        status = true;
                        break;
                    }
                    else if (character == translitForRussian[j])
                    {
                        stringBuilderForOutput.Append(russian[j]);
                        status = true;
                        break;
                    }
                }
                if (status == false)
                {
                    stringBuilderForOutput.Append(sourceCharArray[i]);
                }
            }
            Console.WriteLine(stringBuilderForOutput.ToString());
            return stringBuilderForOutput.ToString();
        }
    }
}