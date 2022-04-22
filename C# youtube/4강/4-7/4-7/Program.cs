using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = 1;
            switch (nNum)
            {
                case 1: 
                    Console.WriteLine("1 입니다.");
                    break; //break를 안쓰면 에러
                case 2:
                    Console.WriteLine("2 입니다.");
                    break;
            }
        }
    }
}
