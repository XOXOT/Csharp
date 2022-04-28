using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class A
    {
        ArrayList List = new ArrayList(); //ArrayList는 객체이기 때문에 new를 통해서 생성, 생략이므로 private
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < List.Count)
                    return (string)List[index];
                else
                    return null;
            }

            set
            {
                if (index >= 0 && index < List.Count)
                    List[index] = value;
                else if (index == List.Count)
                    List.Add(value);//list의 수보다 같다면 수정이 아닌 추가                  
            }
        }

        public void Print()
        {
            foreach(string m in List)
            {
                Console.WriteLine(m);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A Test = new A();
            Test[0] = "A";
            Test[1] = "B";
            Test[2] = "C";
            Test[3] = "D";
            Test.Print();
            Test[1] = "Hello World!";
            Test.Print();
        }
    }
}
