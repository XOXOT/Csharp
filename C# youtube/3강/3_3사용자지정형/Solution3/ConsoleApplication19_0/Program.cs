using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19_0
{
    public struct MyStruct
    {
        public int Age; //디폴트 0
        public float Num2; //디폴트 0
        public bool IsReady; //디폴트 false 
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
