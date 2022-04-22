using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            try
            {
                m = 12;
                Console.WriteLine("try문 출력 :{0}", m);
            }
            catch
            {
                Console.WriteLine("예외 발생");
            }

            Console.WriteLine("try 문 밖에서 변수 출력 {0}", m); // <-- 에러 표시
            //try catch 밖에서 m 변수 사용 불가
            //하지만 위와 같이 밖에서 한번 초기화를 했다면 try catch 안에서 다시 초기화 된 m 변수 값이 적용됨
        }
    }
}
