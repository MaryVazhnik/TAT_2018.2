using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1
{
    class CounterOfTheSameCharacters
    {
        static void Main(string[] args)
        {
            try
            {
                StringBuilder stringBuilderForSourceString = new StringBuilder();
                foreach (var c in args)
                {
                    stringBuilderForSourceString.Append(c).Append(" ");
                }

                string finishedString = stringBuilderForSourceString.ToString();
                finishedString = finishedString.Replace(" ", "");
                char previousCharacter = ' ';
                int count = 0;
                do
                {
                    foreach (var letter in finishedString)
                    {
                        foreach (char character in finishedString)
                        {
                            if (character != previousCharacter && character == letter)
                            {
                                count++;
                            }
                        }

                        Console.WriteLine("Characters {0} = {1}", letter, count);
                        count = 0;
                        previousCharacter = letter;
                    }
                    finishedString.Remove(previousCharacter);
                } while (finishedString != String.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}