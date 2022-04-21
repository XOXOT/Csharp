using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-15 구조체 안의 const 또는 static 변수에 대해서만 선언과 동시에 초기화하는 예이다.
namespace ConsoleApplication15
{
    public struct MyStruct
    {
        public const float PI = 3.14f;
        public static int Age = 12;
        public /*static*/ int val;
    } 
   

    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);
            //PI와 AGE가를 . 형태로 바로 쓸 수 있는 이유는 static 변수 
            //그리고 const는 자동으로 정적 변수와 동일하게 적용

            //테스트
            //MyStruct.val = 10; // 선언 or 생성을 해야지 쓸 수 있음 (static을 붙여야함)
            //Console.WriteLine(MyStruct.val);
        }
    }
}
