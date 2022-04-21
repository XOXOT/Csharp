using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-17
namespace ConsoleApplication17
{
    public struct MyStruct
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1, TestStruct2; //선언과 동시에 메모리 생성 구조체 변수 2개 생성
            MyStruct test;
            TestStruct2.Age = 10;
            test = new MyStruct(); //new는 디폴트 0
            Console.WriteLine(test.Age); // 값이 없으니 디폴트 0 

            TestStruct1 = TestStruct2; //TestStruct1 초기화
            Console.WriteLine("{0}", TestStruct1.Age); //10이 복사 됨
        }
    }
}
