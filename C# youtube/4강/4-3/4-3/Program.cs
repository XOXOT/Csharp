using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3 //데이터형과 객체에 대한 호환을 알아보는 is  
{
    class Program
    {
        static void Main(string[] args)
        {
            int nValue = 10;
            if (nValue is float)
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            if (nValue is object)  // boxing 호환
                Console.WriteLine("호환됨");
            else
                Console.WriteLine("호환 안 됨");

            object obj = nValue; //nValue를 obj에 박싱
            if(obj is int) //obj를 int로 언박싱이 가능한가? 
            {
                Console.WriteLine("호환됨");
            }
            else
            {
                Console.WriteLine("호환 안 됨");
            }
        }
    }
}
