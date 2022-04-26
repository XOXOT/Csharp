using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    //박싱과 언박싱 클래스 참조 구분
    class A
    {   
        public void PrintA() { Console.WriteLine("Hello"); }
    }

    class B : A
    {
        public void PrintB() { Console.WriteLine("World"); }
    }

    class Program
    {
        static void Main(string[] args)
        {        
            B Test1 = new B();
            object obj = Test1; 
            A Test2 = (A)obj; //이것은 박싱 언박싱이 아닌 참조 변환이다. 
            Test2.PrintA();
            Test1.PrintB();           
        }
    }
}
