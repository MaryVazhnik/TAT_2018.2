using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPAdress ipAdress = new IPAdress();
                Console.WriteLine(ipAdress.IPAdressSearch(args));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}