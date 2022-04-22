using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Program
    {
        static void TransArray(string[] arr) //arr이라는 별명을 통해서 Days의 내용이 바뀐다.
            //즉 arr은 Days의 참조형 배열 변수
        {
            string[] HangulDays = { "일", "월", "화", "수", "목", "금", "토" };
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = HangulDays[i];
            }
        }

        static void Main(string[] args)
        {
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; //여기에 있던 영문이 
            TransArray(Days); //이 함수에 의해서 한글로 바뀐다.
            foreach (string str in Days)
                Console.Write(str);
        }
    }
}
