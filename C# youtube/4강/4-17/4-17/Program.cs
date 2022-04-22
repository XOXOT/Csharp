using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17
{
    public class EHClass
    {
        void ReadFile(int index)
        {
            string path = @"c:\users\public\test.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            char[] buffer = new char[10];
            try
            {
                file.ReadBlock(buffer, index, buffer.Length);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}",
                                       path, e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
