using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19_0
{
    public struct MyStruct
    {
        public int Age;
        public float Num2;
        public bool IsReady;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct test = new MyStruct();
            Console.WriteLine("{0} {1} {2}", 
                     test.IsReady, test.Age, test.Num2);
        }
    }
}
