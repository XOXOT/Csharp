using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 소스 3-3 byte형 두 값을 더하고 그 값을 int형 변수에 대입하여 출력해 보자.
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result;
            byte x = 1, y = 2;   
            Result = x + y;
            Console.WriteLine(Result);
        }
    }
}
