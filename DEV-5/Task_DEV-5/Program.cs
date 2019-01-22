using System;

namespace Task_DEV-5
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataProcessing data = new DataProcessing();
                data.SetInfo();
                data.EnterCommand();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}