using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class A
    {
        private void PrintPrivate() //private 생략 가능 
        {
            Console.WriteLine("private");
        }

        protected void PrintProtected()
        {
            Console.WriteLine("protected");
        }

        public void PrintPublic()
        {
            Console.WriteLine("public");
        }
    }

    class B : A //Protected, Public만 접근 가능 
    {
        public void Print()
        {
            //PrintPrivate();
            PrintProtected();
            PrintPublic();
        }
    }

    class Program
    {
        static void Main(string[] args) //public만 접근 가능 
        {
            B Test = new B();
            Test.Print();
            Test.PrintPublic(); //a클래스에 있는 것 중 유일하게 main에서 접근 가능
        }
    }
}
