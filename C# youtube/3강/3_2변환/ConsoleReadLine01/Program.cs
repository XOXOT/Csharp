using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 소스 3-11  사용자가 눌린 키를 출력하는 프로그램을 작성해 보자.
namespace ConsoleReadLine01
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo KeyInfo;
            // KeyInfo라는 변수를 ConsoleKeyInfo 타입으로 선언.
            do
            {
                KeyInfo = Console.ReadKey(true); //true여서 입력을 해도 화면에 표시 안함
                if (KeyInfo.KeyChar == 'a')
                    Console.WriteLine("a가 눌렸어");
               // Console.Write(KeyInfo.KeyChar);

            } while (KeyInfo.Key != ConsoleKey.Escape);
        }
    }
}

namespace Readkey함수
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
                if (KeyInfo.Key == ConsoleKey.A)
                    Console.WriteLine("a가 눌러졌습니다.");
                // KeyInfo의 Key값이 대문자, 소문자 상관없이 A Key가 눌러졌으면
                // "a가 눌러졌습니다"라는 동일한 값을 출력.
                // 그러나, ConsoleKey.A의 저장값은 대문자임.
            }
            while (KeyInfo.Key != ConsoleKey.Escape);
        }
    }

   namespace Readkey함수
    {
        class Program
        {
           static void Main(string[] args)
            {
                ConsoleKeyInfo KeyInfo;
                // KeyInfo라는 변수를 ConsoleKeyInfo 타입으로 선언.
                do
                {
                    KeyInfo = Console.ReadKey(false);
                    if (KeyInfo.KeyChar == 'A')
                        Console.WriteLine(" : A가 눌러졌습니다.");
                    else if (KeyInfo.KeyChar == 'a')
                        Console.WriteLine(" : a가 눌러졌습니다.");
                }
                while (KeyInfo.Key != ConsoleKey.Escape);
            }
        }
    }
}