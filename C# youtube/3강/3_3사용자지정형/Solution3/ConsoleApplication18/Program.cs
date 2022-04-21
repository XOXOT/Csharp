using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-18 구조체의 값 형식과 클래스의 참조 형식을 비교하는 소스를 입력하고 출력을 살펴보자.
// 그리고 값 형식은 일반 변수와 값으므로 구조체의 값 변화는 다른 구조체에게 영향을 주지 않지만 
// 참조 형식은 객체를 참조하는 것이므로 서로에게 값의 영향을 준다.

namespace ConsoleApplication18
{
    public struct MyStruct
    {  
        public int Age;       
    }

    class MyClass
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyStruct test1 = new MyStruct();
            //test1.Age = 12;
            //MyStruct test2 = test1;
            //test2.Age = 24;
            //Console.WriteLine("{0} {1}", test1.Age, test2.Age);

            MyClass test3 = new MyClass();
            test3.Age = 12;
            MyClass test4 = test3;
            test4.Age = 24;
            Console.WriteLine("{0} {1}", test3.Age, test4.Age);          
        }
    }
}
