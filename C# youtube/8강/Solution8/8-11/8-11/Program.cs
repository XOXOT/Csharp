using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_11
{
    class MyClass
    {
        public int number;
        public MyClass() //생성자
        {
            number = 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass MyTest = new MyClass(); //MyTest는 현재 객체 
            MyClass RefClass = MyTest; //대입연산자를 통해 RefClass는 MyTest를 참조하는 별명이 됨
            RefClass.number = 7; 
            Console.WriteLine(MyTest.number);
        }
    }
}
