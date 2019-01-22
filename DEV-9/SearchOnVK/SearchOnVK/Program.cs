using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchOnVK
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string login = "+375259486802";
                string password = "10111997abc";
                SearchElements element = new SearchElements();
                element.Info(login, password);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}