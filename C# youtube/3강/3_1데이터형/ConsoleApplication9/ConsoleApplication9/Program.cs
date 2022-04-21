using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int? Num1 = null;
            
            if (Num1.HasValue)
                Console.WriteLine("올바른 값");
            else
                Console.WriteLine("null 값");

            Console.WriteLine("null : {0}",  Num1);
            Console.WriteLine(Num1.HasValue);
        }
    }
}
