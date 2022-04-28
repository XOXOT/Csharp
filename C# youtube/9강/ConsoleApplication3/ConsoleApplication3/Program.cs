using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class A
    {
        int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public A(int count)
        {
            this.count = count;
        }

        public void Print()
        {
            Console.WriteLine(count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A(3);                      
            Console.WriteLine(Test.Count);

            Test.Count = 20;
            Test.Print();
        }
    }   
}
