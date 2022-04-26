using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    abstract class A
    {
        int number = 3;
        public abstract void Print(); //나중에 구현을 해줘야함
        public void PrintNumber() //구현이 되어있음
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class"); //A클래스의 Print 메서드 구현
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();
            Test.PrintNumber();

           

        }
    }
}
