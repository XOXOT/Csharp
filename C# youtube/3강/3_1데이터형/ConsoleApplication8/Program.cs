using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-8   데이터형이 분명한 var형을 선언한 후에 초기화해 보고 두 값을 더한 결과를 출력해 보자.
namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var value1 = 3.14f;
            float value2 = 10.12f;
            float sum = value1 + value2;
            Console.WriteLine("{0} + {1:f2} =  {2}", value1, value2, sum); //:f2는 소수 점 2자리
        }   
    }
}
