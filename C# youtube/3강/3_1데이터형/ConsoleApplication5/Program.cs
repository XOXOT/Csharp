using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-5 다음과 같이 두 문자열을 합친 후에 합친 문자열과 다섯 번째 문자를 출력해 보자.
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1 + str2;
            string str4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, str4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!")
            {
                Console.WriteLine("같음");
            }
            else {
                Console.WriteLine("다름");
            }
        }
    }
}
