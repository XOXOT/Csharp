using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            try
            {
                i = 12;
            }
            finally
            {
                i = 100;
                Console.WriteLine("finally 문 i 값 : {0}", i);
            }

            i = 200;
            Console.WriteLine("try finally문 밖에서 실행 i 값 :{0}", i);
        }
    }
}
