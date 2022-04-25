using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class A
    {
        int number;
        protected string name = "Hello";
        public A(int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        string name = "World";
        public B(int num):base(num) //상위 클래스 변수를 쓰기 위해 : base 필수
        {
            //하위 클래스인 B에서 int 값을 넣으면 상위 클래스 A가 먼저 값이 변경되고 그 다음 B가 변경됨
        }

        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name);//여기서 base.name은 A클래스 name
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B Test = new B(3); //A에서 먼저 3으로 셋업된 후 B에 셋업
            Test.PrintA();
            Test.PrintB();
        }
    }
}
