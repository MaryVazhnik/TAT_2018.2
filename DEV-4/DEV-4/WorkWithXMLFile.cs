using System;
using System.Text;
using System.IO;

namespace DEV_4
{
    class WorkWithXMLFile
    {
        public string Enter(string name)
        {
            string text = String.Empty;
            using (StreamReader fileToRead = new StreamReader(name))
            {
                while (true)
                {
                    string temporaryString = fileToRead.ReadLine();
                    if (temporaryString == null)
                        break;
                    text += temporaryString;
                }
            }
            return text;
        }
        /// <summary>
        /// The method that make parse the document
        /// </summary>
        /// <param name="text"></param>
        public void Parse(string text)
        {
            while (text.IndexOf("  ") > -1)
            {
                text = text.Replace("  ", " ");
                text = text.Replace(">", ">@");
                text = text.Replace("<", "@<");
                string[] split = text.Split('@');
                string[] elements = new string[0];
                string[] atribut = new string[0];
                string tempItem;
                int index = 0;
                bool flag = false;
                for (int j = 0; j < split.Length; j++)
                {
                    if (flag)
                    {
                        Console.Write(" - " + split[j - 2]);
                        Console.WriteLine();
                        flag = false;
                    }
                    if (split[j].IndexOf("<") == 0)
                    {
                        if (split[j].IndexOf("/") != 1)
                        {
                            Array.Resize<string>(ref elements, elements.Length + 1);
                            tempItem = split[j].Replace("<", "");
                            tempItem = tempItem.Replace(">", "");
                            elements[elements.Length - 1] = tempItem;
                        }
                        else
                        {
                            tempItem = split[j].Replace("</", "");
                            tempItem = tempItem.Replace(">", "");
                            for (int i = 0; i < elements.Length; i++)
                            {
                                Console.Write(elements[i]);
                                if (elements[i].IndexOf(tempItem) > -1)
                                {
                                    index = i;
                                    break;
                                }
                                Console.Write(" - ");
                            }
                            flag = true;
                            Array.Resize<string>(ref elements, index);
                        }
                        tempItem = String.Empty;
                    }
                }
            }
        }
    }
}