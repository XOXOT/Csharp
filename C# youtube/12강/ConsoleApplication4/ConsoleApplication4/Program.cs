using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        } 
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B();
            Test.Print();

            A Test1 = Test;
            Test1.Print();
        }
    }
}
