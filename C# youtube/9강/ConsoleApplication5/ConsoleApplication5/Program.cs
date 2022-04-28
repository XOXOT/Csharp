using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

    class A
    {
        int[] number = { 1, 2, 3, 4, 5 };
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            A Test = new A();
            Console.WriteLine(Test[2]);
            Test[2] = 300;
            Console.WriteLine(Test[2]);
        }
    }
}
