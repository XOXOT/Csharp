using System;

namespace 인덱스
{
    class A
    {
        private int[] number = new int[5]; //클래스를 선언할 때 선언 가능하지만 크기가 정해져있음
        public int this[int index]
        {
            get { return number[index];}
            set { number[index] = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A test = new A();
            for(int i = 0; i < 5; i++)
            {
                test[i] = i;
                Console.WriteLine(test[i]);
            }
        }
    }
}
