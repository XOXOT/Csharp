using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nArray = { 1, 2, 3, 4 }; //int[] array = new int[] {1,2,3,4} 동일 
            for (int i = 0; i < 4; i++)
                Console.Write("{0} ", nArray[i]);
            Console.Write('\n');

            for (int i = 0; i < nArray.Length; i++) //nArray.Length 배열 요소의 개수
                Console.Write("{0} ", nArray[i]);
            Console.Write('\n');

            foreach (int m in nArray) //컬렉션도 가능 
                Console.Write("{0} ", m);
            Console.Write('\n'); 
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (string str in Days)
                Console.Write(str + " "); //띄워서 출력 
        }
    }
}
