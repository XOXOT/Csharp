using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool value = true;
            switch (value)
            {
                case true:
                    Console.WriteLine("true 입니다.");
                    break;
                case false:
                    Console.WriteLine("false 입니다.");
                    break;
            }
        }
    }
}
