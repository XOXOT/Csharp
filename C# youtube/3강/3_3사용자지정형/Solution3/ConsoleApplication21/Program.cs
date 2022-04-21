using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-17 일반적 선언과 new를 통해 생성한 객체에 대한 초기값을 출력해 보자.
namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int nVal1 = 12;
            int nVal2 = new int();
            Console.WriteLine("{0} {1}", nVal1, nVal2);

            char[] test = { 'a', 'b', 'c' };
            string a = new string(test);
            string b = a;
            
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
