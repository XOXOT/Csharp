using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    public struct MyStruct
    {
        public int Age;

        public MyStruct(int InAge)
        {
            Age = InAge;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct Test1 = new MyStruct();
            MyStruct Test2 = new MyStruct(12);           
            Console.WriteLine("{0} {1}", Test1.Age, Test2.Age);
        }
    }
}
