using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "yes";
            switch (str)
            {
                case "no":
                    Console.WriteLine("no 입니다.");
                    break;
                case "yes":
                    Console.WriteLine("yes 입니다.");
                    break;
            }
        }
    }
}
