using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_18
{
    class Program
    {
        static int GetNumber(int index)
        {
            int[] nums = { 300, 600, 900 };
            if (index >= nums.Length)
            {
                throw new IndexOutOfRangeException(); //Exception 파생된 객체만 사용 가능 (new 필수)
            }
            return nums[index];
        }

        static void Main(string[] args)
        {
            int result = GetNumber(3);
        }
    }
}
