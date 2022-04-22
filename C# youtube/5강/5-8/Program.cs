using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8
{
    class Program
    {
        static void Main(string[] args) //배열 복사 메서드
        {
            int[] nArray1 = { 1, 2, 3, 4 };
            int[] nCloneArray = (int[])nArray1.Clone(); //Clone은 복사 함수

            nCloneArray[2] = 30;
            foreach (int m in nArray1)
                Console.Write(m); //1 2 3 4
            Console.WriteLine();

            foreach (int m in nCloneArray)
                Console.Write(m); //1 2 30 4
            Console.WriteLine();

            string[] Days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] DaysClone = (string[])Days.Clone();
            foreach (string str in DaysClone)
                Console.Write(str);
            Console.WriteLine();
        }
    }
}
