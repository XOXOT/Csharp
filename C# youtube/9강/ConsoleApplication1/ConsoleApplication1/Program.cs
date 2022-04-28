using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class A
    {
        private int number;
        private string name;
        public string Name // name 변수의 속성명은 대문자로 구분하는 것이 좋음
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set
            {
                if (value < 0 || value > 9) // 0보다 작거나 9보다 큰 애들은 
                    number = 0; //0으로 처리 
                else
                    number = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            test.Name = "Microsoft C#"; //set 동작
            test.Number = 9;
            Console.WriteLine("{0},{1}", test.Name, test.Number); //get 동작
            test.Number = -7;
            Console.WriteLine(test.Number);
            DateTime.Now.Subtract
        }
    }
}
