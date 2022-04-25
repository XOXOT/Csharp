using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
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
            A Test1 = new B();
            Test1.Print();

            //-------- cast 형을 이용한 참조 
            B Test2 = new B();
            A Test3 = Test2;
            Test3.Print();
        }
    }
}
