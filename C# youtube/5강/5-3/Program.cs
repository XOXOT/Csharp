using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[2][]; //행을 먼저 선언 
            array[0] = new int[3] { 1, 2, 3 }; //int 옆에 [ ] 생략 가능
            array[1] = new int[2] { 4, 5 };

            for (int i = 0; i < array.Length; i++) //여기서 length는 행 
            {
                for (int j = 0; j < array[i].Length; j++) //여기서 length는 열
                    Console.Write(array[i][j]);
            }
        }
    }
}
