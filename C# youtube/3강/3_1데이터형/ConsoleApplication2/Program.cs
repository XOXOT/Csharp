using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            char Mun = '7';  // 문자상수값 = 55
            int Num = Mun; // 암시적 형 변환
            Num = Num + 1;
            Console.WriteLine("Mun = {0} 문자상수값 = {1} 유니코드문자 = {2}",
                                  (int)Mun /*cast 연산자 명시적이지만 임시적으로 변환*/, Num, (char)Num);
            Mun = (char)Num;
            Console.WriteLine(Mun);

        }
    }
}
