using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                Console.WriteLine("try 문에서 예외 발생시킵니다");
                array[3] = 10;
            }       
            //catch(...)
            finally
            {
                Console.WriteLine("finally 구문입니다."); //예외가 발생해도 무조건 실행
            }

            foreach(var m in array)
                Console.Write("{0} ", m);            
        }
    }
}
