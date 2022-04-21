using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3-10  사용자가 눌린 키를 화면에 출력하되 Escape 키가 입력되면 프로그램을 종료하도록 작성해 보자.
namespace ConsoleRead01
{
    class Program
    {
        static void Main(string[] args)
        {           
            ConsoleKeyInfo KeyInfo;
            // KeyInfo라는 변수를 ConsoleKeyInfo 타입으로 선언.
            do
            {
                KeyInfo = Console.ReadKey();
                // 문자를 입력받아 화면에 출력하고 KeyInfo에 저장.
                // Console.ReadKey()에 false가 입력되면 화면출력 후 진행.
                // Console.ReadKey()에 true가 입력되면 화면출력없이 진행.

                if (KeyInfo.Key == ConsoleKey.A)
                    Console.WriteLine("a가 눌렸다");
            } while (KeyInfo.Key != ConsoleKey.Escape);
            // KeyInfo의 Key값이 Esc이면 종료.
        }
    }
}