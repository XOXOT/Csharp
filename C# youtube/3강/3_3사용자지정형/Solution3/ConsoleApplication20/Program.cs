using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-16 요일에 대한 열거형 변수를 정수형 변수에 대입하여 출력하여 보자.
namespace ConsoleApplication20
{
    enum Days : byte { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat };

    class Program
    {
        static void Main(string[] args)
        {
            byte nValue = (byte)Days.Mon;
            Days day = Days.Tue;
            Console.WriteLine("{0} {1}", nValue, day);
        }
    }
}
