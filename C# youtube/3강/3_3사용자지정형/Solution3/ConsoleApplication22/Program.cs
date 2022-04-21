using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3 };
            int[] RefArray;  // 참조형 배열 변수 별명이다!
            RefArray = Array1;
            RefArray[1] = 20;
            Console.WriteLine("{0} {1} {2}", Array1[0], Array1[1], Array1[2]);
        }
    }
}
