using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class A
    {
        public void Print() { Console.WriteLine("Hi!"); }
        public void Print(int num)
        {
            Console.WriteLine(num);
        }

        public float Print(int num, float pi)
        {
            Console.WriteLine("{0} {1}", num, pi);
            return pi;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            Test.Print();
            Test.Print(100);

            float pi = Test.Print(3, 3.14f);
            Console.WriteLine(pi);            
        }
    }
}
