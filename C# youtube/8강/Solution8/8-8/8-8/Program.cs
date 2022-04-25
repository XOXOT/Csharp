using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_8
{
    class MyClass
    {
        ~MyClass() //가비지 컬렉터에서 알아서 잘해서 생략이 가능하다. 
        {
            Console.WriteLine("소멸자 호출");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass Test1 = new MyClass();
        }
    }
}
