using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_13
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                array[3] = 10; //범위를 벗어나 에러
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("배일 인덱스 에러 발생");
                Console.WriteLine(e.ToString()); //ToString() 에러가 어디서 났는지 원인에 대한 설명을 출력해줌
                array[2] = 10;
            }

            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);            
        }
    }
}
