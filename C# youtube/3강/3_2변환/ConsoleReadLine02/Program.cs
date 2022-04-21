using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadLine02
{
    class Program
    {
        static void Main(string[] args)
        {
            int Kor, Eng, Math, Total;
            float Average;
            //console.readline 엔터키가 눌러질 때까지 입력 받은 문자열을 리턴하는 메서드

            Console.Write("국어 점수를 입력해 주세요 : ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수를 입력해 주세요 : ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수를 입력해 주세요 : ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} {3} {4:f1}", Kor, Eng, Math, Total, Average);
        }
    }
}
