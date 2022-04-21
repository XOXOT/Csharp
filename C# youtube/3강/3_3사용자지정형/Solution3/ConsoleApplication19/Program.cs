using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-15 국어, 영어, 수학 점수를 구조체 멤버 변수로 입력하고 Compute() 메서드를 호출하면 평균과 총점이 계산되도록 하여 프로그래밍하면 다음과 같다.
namespace ConsoleApplication15
{
    public struct MyStruct
    {
        public int Kor, Eng, Math, Total;
        public float Average;

        public void Compute() //public 필수
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct Test1 = new MyStruct();
            Test1.Kor = 80;
            Test1.Eng = 90;
            Test1.Math = 88;
            Test1.Compute();
            Console.WriteLine("총점 : {0} 평균 : {1:f1}", Test1.Total, Test1.Average);
        }
    }
}
