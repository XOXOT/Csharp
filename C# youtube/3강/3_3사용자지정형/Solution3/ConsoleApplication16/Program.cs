using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-12 구조체에 생성자와 소멸자를 명시하고 new로 생성했을 때와 일반 선언 했을 때의 초기화 값을 비교하는 예이다.
namespace ConsoleApplication16
{
    public struct MyStruct
    {
        public int Age;
        public MyStruct(int InAge)
        {
            Age = InAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1;
            TestStruct1.Age = 12;
            Console.WriteLine(TestStruct1.Age);

            MyStruct TestStruct2 = new MyStruct();         
            Console.WriteLine(TestStruct2.Age);

            MyStruct TestStruct3 = new MyStruct(12);
            Console.WriteLine("{0}", TestStruct3.Age);
        }
    }
}
