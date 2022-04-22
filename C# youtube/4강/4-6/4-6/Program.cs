using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = 10;
            if (nNum)  //이렇게 c#은 if문에 true false가 아닌 값을 넣으면 오류가 뜸 
                Console.WriteLine("Hello World!");
            else
                Console.WriteLine("C# Programming");
           
        }
    }
}
