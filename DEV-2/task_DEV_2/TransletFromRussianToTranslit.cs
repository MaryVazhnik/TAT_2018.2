using System;
using System.Text;

namespace task_DEV_2
{
    /// <summary>
    /// class that translates from Russian to translit
    /// </summary>
    class TransletFromRussianToTranslit
    {
        static void Main(string[] args)
        {
            try
            {
                Transliteration translit = new Transliteration();
                char[] sourceCharArray = translit.StringPreparing(args);
                translit.Translate(sourceCharArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}