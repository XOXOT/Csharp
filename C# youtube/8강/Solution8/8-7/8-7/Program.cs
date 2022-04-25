using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_7
{
    class MyClass
    {
        string Message;

        public MyClass(string InputMessage)
        {
            Message = InputMessage;
        }

        public void PrintMesssage()
        {
            Console.WriteLine(Message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {           
            MyClass test = new MyClass("Happy!");
            test.PrintMesssage();
        }
    }
}
