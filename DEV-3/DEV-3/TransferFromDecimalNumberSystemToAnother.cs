using System;
using System.Collections;
using System.Text;

namespace DEV_3
{
    /// <summary>
    /// Translates from the decimal number system to the number system with the base of number system
    /// </summary>
    public class TransferFromDecimalNumberSystemToAnother
    {
        string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        /// <summary>
        /// Translates into the desired number system
        /// </summary>
        /// <param name="number">The number that we convert</param>
        /// <param name="numberSystem">Number system, into which we convert</param>
        public string ToNumberSystem(string number, string numberSystem)
        {
            if (String.IsNullOrEmpty(number) || String.IsNullOrEmpty(numberSystem))
            {
                throw new Exception("Empty string, try again!");
            }
            int scaleOfNotation = Int32.Parse(numberSystem);
            int givenNumber = Int32.Parse(number);
            if (scaleOfNotation <= 20 && scaleOfNotation >= 2 && givenNumber > 0)
            {
                string result = String.Empty;
                int originalNumber = Convert.ToInt32(number);
                int tempVariable = Convert.ToInt32(number);
                ArrayList numbersTempArray = new ArrayList();
                while (tempVariable > 0)
                {
                    tempVariable = tempVariable / Convert.ToInt32(numberSystem);
                    numbersTempArray.Add(originalNumber - tempVariable * Convert.ToInt32(numberSystem));
                    originalNumber = tempVariable;
                }
                int j = 0;
                for (j = numbersTempArray.Count - 1; j >= 0; j--)
                {
                    result += ReplaceLettersWithNumbers(numbersTempArray[j].ToString());
                }
                Console.WriteLine(result);
                return result;
                }
                else
                {
                    throw new Exception("Error");
                }
        }
        /// <summary>
        /// Function, replaces numbers with letters
        /// </summary>
        /// <param name="convertedNumber">The number that we convert</param>
        string ReplaceLettersWithNumbers(string convertedNumber)
        {
            StringBuilder direction = new StringBuilder();
                if (Convert.ToInt32(convertedNumber) >= 10)
                {
                    letters = letters.Substring(Convert.ToInt32(convertedNumber) - 10, 1);
                    direction = direction.Append(letters);
                }
                else
                {
                    direction = direction.Append(convertedNumber);
                }
            return direction.ToString();
        }
    }
}