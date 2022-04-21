using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-12 구조체에 생성자와 소멸자를 명시하고 new로 생성했을 때와 일반 선언 했을 때의 초기화 값을 비교하는 예이다.
namespace ConsoleApplication16
{
    public struct MyStruct
    {
        public int Age; 
        //const와 static 변수가 아니면 초기화를 할 수 없어 밑에 처럼 초기화를 해줘야함
        //생성자를 만들면 생성과 동시에 초기화가 가능
        public MyStruct(int InAge) //생성자에도 public 필수
        {
            Age = InAge;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyStruct TestStruct1; //값 형식 (int 이렇게 안붙여도 선언만해도 객체가 생성되고 메모리도 생성됨) 
            TestStruct1.Age = 12; //생략할 때가 많아 c#에서 아래와 같이 new 연산자를 활용한다.
            Console.WriteLine(TestStruct1.Age);

            MyStruct TestStruct2 = new MyStruct(); // 매개변수가 없으면 기본 생성자가 호출        
            Console.WriteLine(TestStruct2.Age); //값이 없으니 0이 출력(디폴트 0)

            MyStruct TestStruct3 = new MyStruct(12);
            Console.WriteLine("{0}", TestStruct3.Age);
        }
    }
}
