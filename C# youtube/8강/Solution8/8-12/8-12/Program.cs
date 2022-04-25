using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_12
{
    class MyClass
    {
        public int number;
        public MyClass(int number)
        {
            this.number /*(클래스의 변수)*/ = number; /*(생성자 매개변수)*/
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass(12);
            Console.WriteLine(MyTest.number);
        }
    }
}
