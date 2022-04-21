using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 123;
            //object obj = i; //i를 통해 heap 영역 안에 복사
            //Console.WriteLine("{0}", (int)obj);



            int i = 123;
            object o = i; //123이 힙 영역에 저장
            i = 456; // i값을 456으로 바꿔도 o의 값은 변화가 없다. 
            Console.WriteLine("{0} {1}", i, (int)o);
        }
    }
}
