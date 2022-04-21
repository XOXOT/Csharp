using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-16 요일에 대한 열거형 변수를 정수형 변수에 대입하여 출력하여 보자.
namespace ConsoleApplication20
{
    enum Days : byte { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat }; //이렇게 명시적으로 byte로 지정할 수 있고
    enum Dayss { Sun = 1, Mon, Tue, Wed, Thu, Fri, Sat }; //이렇게 생략도 한다. (int)

    class Program
    {
        static void Main(string[] args)
        {
            byte nValue = (byte)Days.Mon;
            int nValue1 = (int)Dayss.Mon; //초기화
            Days day = Days.Tue; //변수 값 설정
            Dayss dayy = Dayss.Tue; //변수 값 설정

            Console.WriteLine("{0} {1}", nValue, day);
            Console.WriteLine("{0} {1}", nValue1, dayy);
        }
    }
}
