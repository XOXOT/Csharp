using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6
{
    class MyClass
    {
        string Message; //변수

        public MyClass() //생성자
        {
            Message = "Hello World"; //멤버에 대한 초기화를 해주는 생성자
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
            MyClass MyTest = new MyClass(); //호출을 하지 않아도 자동으로 Hello World 셋업이 되어있음
            MyTest.PrintMesssage();
        }
    }
}
