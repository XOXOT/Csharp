using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    delegate void DelegateType(string str); //void 및 string 아래 메서드와 맞춰야함 

    class A
    {
        public void Print(string str) //void 및 string 
        {
            Console.WriteLine(str);
        }
    }    

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            DelegateType DelMethod1 = new DelegateType(Test.Print);  // C# 1.0 이상에서 생성하여 사용
            DelMethod1("Hello World1"); //델리게이트 별명이 위의 A클래스의 Print 매서드를 대신하고 있음 

            DelegateType DelMethod2 = Test.Print; // C# 2.0 이상에서 사용 가능
            DelMethod2("Hello World2");
        }
    }
}
