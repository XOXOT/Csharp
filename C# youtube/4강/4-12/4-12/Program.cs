using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections 네임스페이스에서는 ArrayList, Hashtable, Queue, Stack 등의 컬렉션을 제공
            //클래스	    설명
            //ArrayList     필요에 따라 크기가 동적으로 증가하는 개체 배열을 나타냅니다
            //Hashtable     키의 해시 코드에 따라 구성된 키/ 값 쌍의 컬렉션을 나타냅니다
            //Queue         FIFO(선입선출) 방식의 개체 컬렉션을 나타냅니다
            //Stack         LIFO(후입선출) 방식의 개체 컬렉션을 나타냅니다

            ArrayList List = new ArrayList(); //컬렉션 System.Collections
            List.Add(1);
            List.Add(2);
            List.Add(3);
            foreach (int m in List)
            {
                Console.WriteLine(m);
            }
        }
    }
}
