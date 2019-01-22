using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_2
{
    public class IPAdress
    {
        public string IPAdressSearch(string[] args)
        {
            StringBuilder stringBuilderForSourceString = new StringBuilder();
            foreach (var c in args)
            {
                stringBuilderForSourceString.Append(c).Append(" ");
            }

            StringBuilder part = new StringBuilder();
            string unit = String.Empty;
            string finishedString = stringBuilderForSourceString.ToString();
            string[] parts = finishedString.Split(' ');
            foreach (var p in parts)
            {
                part.Append(p);
            }

            unit = part.ToString();
            string[] portion = unit.Split('.');
            if (portion.Length < 4)
            {
                Console.WriteLine("Not a IPv4 string in X.X.X.X format");
            }
            else
            {
                foreach (var smallPortion in portion)
                {
                    byte checkPart = 0;
                    if (!byte.TryParse(smallPortion, out checkPart))
                    {
                        Console.WriteLine("Not a valid IPv4 string in X.X.X.X format");
                    }
                }
            }
            return unit;
        }
    }
}