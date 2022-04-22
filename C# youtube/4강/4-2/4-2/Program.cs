using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "3" + ".14";
            Console.WriteLine(+5);        // 숫자 양 5
            Console.WriteLine(5 + 5);     // 숫자 10
            Console.WriteLine(5 + .5);    // 숫자 5.5 .앞에 0 생략 가능
            Console.WriteLine("5" + "5");  // 문자열 55
            Console.WriteLine(5.01f/*(부동소수)*/ + "5"); // 문자열 5.015
            Console.WriteLine(3.14f + "5"); // 문자열 3.145
            Console.WriteLine(str);        // 문자열 3.14
            str = 1 + "test" + 3.14f + "abcd";
            Console.WriteLine(str);
        }
    }
}
