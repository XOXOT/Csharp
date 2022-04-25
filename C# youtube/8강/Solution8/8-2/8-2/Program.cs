using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Date //internal이 디폴트라 생략
    {

        ////[8-2]
        //int Day; //생략이 되었으니 PRIVATE
        //public int Year, Month;

        //[8-3]
        public int Year;
        protected int Month;
        int Day;

        void Print() //이것도 마찬가지로 생략되어 있으므로 PRIVATE이라 메인에서 사용 불가
        {
            Console.WriteLine("{0} {1} {2}", Year, Month, Day);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ////[8-2]
            //Date Test = new Date();
            //Test.Month //Day 변수는 private라 호출이 안됨

            //[8-3]
            Date Test = new Date();
            

        }
    }
}
