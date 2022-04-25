using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_9
{
    class MyClass
    {
        public static int number = 12; //static 변수이기 때문에 메모리에 이미 생성이 되어있음
        public static void Print() { Console.WriteLine("Hello World!"); } //위와 마찬가지
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Print(); //따라서 static 변수나 함수는 new를 쓰지 않고 바로 사용 가능
            Console.WriteLine(MyClass.number);
            MyClass.number = 200; //변수 값을 바꿔 줄 수 있다. 
            MyClass test = new MyClass(); //객체 생성과 해당이고 static과 상관없음
            Console.WriteLine(MyClass.number);
        }
    }
}
