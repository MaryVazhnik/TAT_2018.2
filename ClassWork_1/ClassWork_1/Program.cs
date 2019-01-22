using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_1
{
    class MakeStack
    {
        static void Main(string[] args)
        {
            try
            {
                Stack stack = new Stack();
                stack.Push(1);
                stack.Push(45);
                stack.Push(95);
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}