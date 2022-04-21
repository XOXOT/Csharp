using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-17
namespace ConsoleApplication17
{
    public struct MyStruct
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1, TestStruct2;
            MyStruct test;
            TestStruct2.Age = 10;
            test = new MyStruct();
            Console.WriteLine(test.Age);

            TestStruct1 = TestStruct2;
            Console.WriteLine("{0}", TestStruct1.Age);
        }
    }
}
