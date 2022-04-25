using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class MyClass
    {
        public int val;
        public void PrintA() { Console.WriteLine("Class A"); }
        void PrintB() { Console.WriteLine("Class B"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass test = new MyClass();
            test.val = 12;
            Console.WriteLine(test.val);
            test.PrintA(); //MyClass PrintB는 private이라 호출할 수 없음
        }
    }
}
