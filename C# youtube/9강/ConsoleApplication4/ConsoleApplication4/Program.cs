using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class A
    {
        int number;
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 9)
                    number = 0;
                else
                    number = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            Test.Name = "C# Language";
            Test.Number = 3;
            Console.WriteLine("{0} {1}", Test.Name, Test.Number);
            Test.Number = -1;
            Console.WriteLine(Test.Number);
        }
    }
}
