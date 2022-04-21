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
       
    } 
   

    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("{0} {1}", MyStruct.PI, MyStruct.Age);           
        }
    }
}
