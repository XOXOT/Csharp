using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{  
    struct DATA
    {
        public string name;
        public int number;

        public DATA(string name, int number)
        {
            this.name = name;
            this.number = number; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            object obj = num;
            int result = (int)obj;
            Console.WriteLine("{0} {1}", num, result);

            //---------------------------------------

            DATA Test = new DATA("test", 3);
            object obj1 = Test;
            DATA Test1 = (DATA)obj1;
            Console.WriteLine("{0 } {1}", Test1.name, Test.number);
        }
    }
}
