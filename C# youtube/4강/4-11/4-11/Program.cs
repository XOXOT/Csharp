using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3, 4 }; //순차적으로 나열되어 있어 foreach 가능
            
            foreach (int nValue in Array1)
            {
                Console.WriteLine(nValue);
                //nValue = nValue + 1; //foreach는 읽기 전용이라 이렇게 값 변환이 안됨
            }
        }
    }
}
