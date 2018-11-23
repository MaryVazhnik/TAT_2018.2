using System;
using System.Text;

namespace DEV_3
{
    /// <summary>
    /// Entry Point
    /// </summary>
    class ConverterOfNumeralSystems
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Number " + args[0] + " in " + args[1] + " number system:");
                TransferFromDecimalNumberSystemToAnother calculat = new TransferFromDecimalNumberSystemToAnother();
                calculat.ToNumberSystem(args[0], args[1]);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}