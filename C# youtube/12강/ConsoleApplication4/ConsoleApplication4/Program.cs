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
        //virtual로 하위 클래스에서 재정의 한다는 이야기 그래서 당연히 public이 와야함
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

            A Test1 = Test; //B클래스에서 재정의를 했으므로 B Print가 나옴 
            Test1.Print();

            A Test2 = new A();
            Test2.Print();
        }
    }
}
