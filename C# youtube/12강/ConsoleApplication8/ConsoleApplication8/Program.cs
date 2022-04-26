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
            this.name = name; //매개변수가 동일하므로 THIS 붙여줌
            this.number = number; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            object obj = num; //3을 객체로 박싱
            int result = (int)obj; //int로 언박싱
            Console.WriteLine("{0} {1}", num, result);

            //---------------------------------------

            DATA Test = new DATA("test", 3);
            object obj1 = Test; //구조체도 값형식이기 때문에 박싱 가능
            DATA Test1 = (DATA)obj1; //구조체로 언박싱
            Console.WriteLine("{0 } {1}", Test1.name, Test.number);
        }
    }
}
