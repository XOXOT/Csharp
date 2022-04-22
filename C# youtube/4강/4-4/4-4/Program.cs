using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class A
    {         
    }

    class B
    {        
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "123";
            object obj = str1; //str1을 obj에 박싱
            string str2 = obj as string; //obj를 string으로 바꿔서 str2에 넣을 수 있는가?
            Console.WriteLine(str2);

            A test1 = new A(); //null값도 저장 가능
            object obj1 = test1; //박싱
            B test2 = obj1 as B; //obj1을 B로 바꿔서 test2에 넣을 수 있는가? --A를 B로 참조를 할 수 없다. 
            if (test2 == null)
                Console.WriteLine("형변환 실패");
            else
                Console.WriteLine("형변환 성공");          
        }
    }
}
