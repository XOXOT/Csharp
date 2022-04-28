using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0
{
    class A
    {
        int[] number = new int[3];
        public int this[int i]
        {
            get { return number[i]; }
            set { number[i] = value; }
        }

        public void print(int i)
        {
            Console.WriteLine(number[i]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A[] Test = new A[3];
            Test[0] = new A();
            Test[0][0] = 12;
            Console.WriteLine(Test[0][0]);
            Test[0].print(0);
        }
    }
}
