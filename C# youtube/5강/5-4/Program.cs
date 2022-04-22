using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] array3 = new int[2][][];  //면, 행, 열

            //두 개의 면
            array3[0] = new int[2][]; //두 개의 행 []은 열이 존재하는 것을 암시
            array3[1] = new int[3][]; //세 개의 열

            //두 개의 행
            array3[0][0] = new int[3] { 1, 2, 3 };
            array3[0][1] = new int[2] { 4, 5 };

            //세 개의 열
            array3[1][0] = new int[3] { 6, 7, 8 };
            array3[1][1] = new int[2] { 9, 10 };
            array3[1][2] = new int[2] { 11, 12 };

            for (int i = 0; i < array3.Length; i++) //면
            {
                for (int j = 0; j < array3[i].Length; j++) //행
                {
                    for (int k = 0; k < array3[i][j].Length; k++) //열 
                    {
                        Console.Write("{0} ", array3[i][j][k]);
                    }                    
                }
            }
        }
    }
}
