using System;
using System.Linq;
using System.Text;

namespace Task_DEV_1
{
    /// <summary>
    /// class that calculates maximum the number of unique not repeating consecutive characters
    /// </summary>
    class FindTheMaxLenghtOfUniqueCharacters
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
                string sourceString = stringBuilderForSourceString.ToString();
                char[] sourceCharArray = sourceString.ToCharArray();
                StringBuilder stringBuilderForUniqueRange = new StringBuilder();
                stringBuilderForUniqueRange.Append(sourceCharArray[0]);
                String rangeOfUniqueChars = stringBuilderForUniqueRange.ToString();
                int countOfUniqueChars = rangeOfUniqueChars.Length;
                String subStringToCurrentIndex = String.Empty;
                String completeString = String.Empty;
                for (int i = 1; i < sourceCharArray.Length - 1; i++)
                {
                    subStringToCurrentIndex = sourceString.Substring(0, i);
                    if (!rangeOfUniqueChars.Contains(sourceCharArray[i]))
                    {
                        stringBuilderForUniqueRange.Append(sourceCharArray[i]);
                        rangeOfUniqueChars = stringBuilderForUniqueRange.ToString();
                    }
                    else
                    {
                        rangeOfUniqueChars = stringBuilderForUniqueRange.ToString();
                        int index = subStringToCurrentIndex.LastIndexOf(sourceCharArray[i]);
                        i = index + 1;
                        if (countOfUniqueChars < rangeOfUniqueChars.Length)
                        {
                            countOfUniqueChars = rangeOfUniqueChars.Length;
                            completeString = rangeOfUniqueChars;
                        }
                        rangeOfUniqueChars = String.Empty;
                        stringBuilderForUniqueRange.Clear();
                    }
                }
                Console.WriteLine("Substring with maximum length: " + completeString +
                    "\nCount of unique elements: " + countOfUniqueChars);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
