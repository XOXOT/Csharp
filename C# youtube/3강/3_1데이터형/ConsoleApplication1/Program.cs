using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-1 클래스의 정적 변수 bool형의 기본 값과 지역 bool 변수 값을 출력해 보자
namespace ConsoleApplication1
{
    class Program
    {
        static bool BoolVar; //bool 타입이 static 멤버 변수로 선언되었을 때 디폴트는 false 이다. 
        static void Main(string[] args) //CLR 때문에 static은 반드시 표기 해야한다.
        {
            bool LocalBoolVar = true;
            Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);
        }
    }
}
