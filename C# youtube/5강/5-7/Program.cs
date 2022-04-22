using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            Array.Clear(nArray1, 2, 3); //static 함수 //nArray1의 배열의 [2]번째 값부터 3번째까지 0으로 초기화// int[] 암시적 업케스팅이 된 것
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();

            Array.Clear(nArray1, 0, nArray1.Length);
            foreach (int m in nArray1)
                Console.Write(m);
            Console.WriteLine();
        }
    }
}
