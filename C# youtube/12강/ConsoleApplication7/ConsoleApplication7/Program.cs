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
            Test1.Print(); //override로 인해 B Print 출력

            //-------- cast 형을 이용한 참조 
            B Test2 = new B();
            //A Test3 = (A)Test2;
            A Test3 = Test2; //(A) 생략해도 상관 X
            Test3.Print(); //override로 인해 B Print 출력
            //float b = 3.14f;
            //int a = (int)b; //a = 3
        }
    }
}
